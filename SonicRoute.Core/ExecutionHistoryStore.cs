using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace SonicRoute.Core
{
    public sealed class ExecutionHistoryStep
    {
        public int Number { get; set; }
        public int Action { get; set; }
        public string TargetApp { get; set; } = "";
        public string Status { get; set; } = "";
        public string Reason { get; set; } = "";
        public long ElapsedMs { get; set; }
    }

    public sealed class ExecutionHistoryEntry
    {
        public string RunId { get; set; } = "";
        public string ParentRunId { get; set; } = "";
        public string RuleId { get; set; } = "";
        public string RuleName { get; set; } = "";
        public string Source { get; set; } = "";
        public DateTime StartedUtc { get; set; }
        public long ElapsedMs { get; set; }
        public string Status { get; set; } = "";
        public int Succeeded { get; set; }
        public int Failed { get; set; }
        public int Skipped { get; set; }
        public int TotalSteps { get; set; }
        public List<ExecutionHistoryStep> Steps { get; set; } = new();
    }

    /// <summary>Opt-in storage. No timer, watcher, permanent worker or startup history read.</summary>
    public sealed class ExecutionHistoryStore : IDisposable
    {
        private const int MaxRecordBytes = 128 * 1024;
        private readonly string _directory;
        private readonly SemaphoreSlim _io;
        private volatile bool _disposed;
        private long _limitBytes;
        private int _pending;
        private readonly object _pendingGate = new();
        private TaskCompletionSource<bool>? _idle;
        public string? LastError { get; private set; }

        public ExecutionHistoryStore(string directory, int limitMb, SemaphoreSlim? io = null)
        {
            _directory = Path.GetFullPath(directory);
            _io = io ?? new SemaphoreSlim(1, 1);
            _limitBytes = (long)Math.Max(1, Math.Min(64, limitMb)) * 1024 * 1024;
        }

        private string Current => Path.Combine(_directory, "recent.jsonl");
        private string Previous => Path.Combine(_directory, "previous.jsonl");

        public async Task AppendAsync(ExecutionHistoryEntry entry)
        {
            lock (_pendingGate)
            {
                if (_disposed) return;
                if (_pending >= 32) { LastError = "queue_full"; return; }
                if (_pending++ == 0) _idle = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
            }
            try
            {
                await _io.WaitAsync().ConfigureAwait(false);
                try
                {
                    if (_disposed) return;
                    await Task.Run(() =>
                    {
                        byte[] bytes = JsonSerializer.SerializeToUtf8Bytes(entry);
                        if (bytes.Length > MaxRecordBytes) { LastError = "record_too_large"; return; }
                        Directory.CreateDirectory(_directory);
                        Trim();
                        long segment = Interlocked.Read(ref _limitBytes) / 2;
                        long existing = File.Exists(Current) ? new FileInfo(Current).Length : 0;
                        if (existing + bytes.Length + 2 > segment)
                        {
                            if (File.Exists(Previous)) File.Delete(Previous);
                            if (File.Exists(Current)) File.Move(Current, Previous);
                        }
                        using (var stream = new FileStream(Current, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read))
                        {
                            // A crash may leave a partial JSON line. Keep it separate from the next record.
                            if (stream.Length > 0)
                            {
                                stream.Seek(-1, SeekOrigin.End);
                                int tail = stream.ReadByte();
                                if (tail != '\n') stream.WriteByte((byte)'\n');
                            }
                            stream.Seek(0, SeekOrigin.End);
                            stream.Write(bytes, 0, bytes.Length);
                            stream.WriteByte((byte)'\n');
                        }
                        LastError = null;
                    }).ConfigureAwait(false);
                }
                finally { _io.Release(); }
            }
            catch (Exception error) { LastError = error.GetType().Name; }
            finally
            {
                lock (_pendingGate) if (--_pending == 0) _idle?.TrySetResult(true);
            }
        }

        public Task WhenIdleAsync() { lock (_pendingGate) return _idle?.Task ?? Task.CompletedTask; }

        public async Task SetLimitAsync(int limitMb)
        {
            Interlocked.Exchange(ref _limitBytes, (long)Math.Max(1, Math.Min(64, limitMb)) * 1024 * 1024);
            await _io.WaitAsync().ConfigureAwait(false);
            try { if (!_disposed) await Task.Run(Trim).ConfigureAwait(false); }
            catch (Exception error) { LastError = error.GetType().Name; }
            finally { _io.Release(); }
        }

        private void Trim()
        {
            long segment = Interlocked.Read(ref _limitBytes) / 2;
            // On a capacity reduction discard the older segment before compacting the newer one.
            if (File.Exists(Current) && new FileInfo(Current).Length > segment)
            {
                if (File.Exists(Previous)) File.Delete(Previous);
                Compact(Current, segment);
            }
            Compact(Previous, segment);
        }

        private static void Compact(string file, long maximum)
        {
            if (!File.Exists(file) || new FileInfo(file).Length <= maximum) return;
            string temporary = file + ".trim";
            try
            {
                using (var input = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var output = new FileStream(temporary, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    input.Position = input.Length - maximum;
                    // Start at a complete record, retaining the newest lines without parsing history.
                    while (input.Position < input.Length && input.ReadByte() != '\n') { }
                    input.CopyTo(output, 8192);
                }
                File.Replace(temporary, file, null);
            }
            finally { if (File.Exists(temporary)) File.Delete(temporary); }
        }

        public async Task<List<ExecutionHistoryEntry>> ReadRecentAsync()
        {
            await _io.WaitAsync().ConfigureAwait(false);
            try
            {
                if (_disposed) return new List<ExecutionHistoryEntry>();
                return await Task.Run(() =>
                {
                    var entries = new Queue<ExecutionHistoryEntry>();
                    foreach (string file in new[] { Previous, Current })
                    {
                        if (!File.Exists(file)) continue;
                        if (new FileInfo(file).Length > 64L * 1024 * 1024) { LastError = "file_too_large"; continue; }
                        using var reader = new StreamReader(file, Encoding.UTF8);
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Length > MaxRecordBytes) { LastError = "record_too_large"; continue; }
                            try
                            {
                                var entry = JsonSerializer.Deserialize<ExecutionHistoryEntry>(line);
                                if (entry == null || entry.Steps == null || entry.Steps.Count > 100
                                    || entry.Steps.Exists(step => step == null || step.TargetApp == null || step.Status == null || step.Reason == null)) continue;
                                entries.Enqueue(entry);
                                if (entries.Count > 200) entries.Dequeue();
                            }
                            catch (JsonException) { LastError = "invalid_record"; }
                        }
                    }
                    var result = new List<ExecutionHistoryEntry>(entries);
                    result.Reverse();
                    return result;
                }).ConfigureAwait(false);
            }
            catch (Exception error) { LastError = error.GetType().Name; return new List<ExecutionHistoryEntry>(); }
            finally { _io.Release(); }
        }

        public async Task<bool> ClearAsync()
        {
            await _io.WaitAsync().ConfigureAwait(false);
            try
            {
                if (_disposed) return false;
                await Task.Run(() =>
                {
                    if (File.Exists(Current)) File.Delete(Current);
                    if (File.Exists(Previous)) File.Delete(Previous);
                }).ConfigureAwait(false);
                LastError = null;
                return true;
            }
            catch (Exception error) { LastError = error.GetType().Name; return false; }
            finally { _io.Release(); }
        }

        // Do not block a UI toggle waiting for storage. A write already underway may finish.
        public void Dispose() => _disposed = true;
    }
}
