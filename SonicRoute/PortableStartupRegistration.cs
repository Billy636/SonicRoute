using System;

namespace SonicRoute
{
    internal static class PortableStartupRegistration
    {
        internal const string ValueName = "SonicRoute";

        internal static bool Read(Func<string, string?> readValue)
            => !string.IsNullOrWhiteSpace(readValue(ValueName));

        internal static void Write(bool enabled, string? executablePath, Action<string, string?> writeValue)
            => writeValue(ValueName, enabled ? Command(executablePath) : null);

        internal static void Repair(string executablePath, Func<string, string?> readValue, Action<string, string?> writeValue)
        {
            string? current = readValue(ValueName);
            if (string.IsNullOrWhiteSpace(current)) return; // Never recreate a removed entry.
            string expected = Command(executablePath);
            if (!string.Equals(current.Trim(), expected, StringComparison.OrdinalIgnoreCase))
                writeValue(ValueName, expected);
        }

        private static string Command(string? executablePath)
        {
            if (string.IsNullOrWhiteSpace(executablePath)) throw new InvalidOperationException("Executable path is unavailable.");
            return $"\"{executablePath}\"";
        }
    }
}
