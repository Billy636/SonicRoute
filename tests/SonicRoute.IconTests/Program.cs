using System.Diagnostics;
using System.Windows.Media.Imaging;
using SonicRoute;

// Run unelevated; optional arguments are live PIDs for elevated/protected apps.
// dotnet run --project tests/SonicRoute.IconTests -f net8.0-windows -- <PID> ...
internal static class Program
{
    [STAThread]
    private static int Main(string[] args)
    {
        int failures = 0;
        void Check(bool passed, string name)
        {
            Console.WriteLine($"{(passed ? "PASS" : "FAIL")} {name}");
            if (!passed) failures++;
        }

        using var current = Process.GetCurrentProcess();
        var icon = AppIconService.GetIconForPid(current.Id);
        Check(icon is BitmapSource bitmap && bitmap.PixelWidth > 0 && bitmap.IsFrozen,
            "current process returns a frozen image for background loading");
        Check(ReferenceEquals(icon, AppIconService.GetIconForPid(current.Id)) && icon != null,
            "repeated requests reuse the path cache");
        Check(AppIconService.GetIconForPid(0) == null, "system idle PID returns null");
        Check(AppIconService.GetIconForPid(-1) == null, "negative PID returns null");
        Check(AppIconService.GetIconForPid(int.MaxValue) == null, "missing PID returns null");
        Check(AppIconService.GetIconForPath(null) == null, "missing path returns null");

        using (var exited = Process.Start(new ProcessStartInfo("cmd.exe", "/c exit 0")
        {
            UseShellExecute = false,
            CreateNoWindow = true
        }))
        {
            exited!.WaitForExit();
            Check(AppIconService.GetIconForPid(exited.Id) == null, "exited process returns null");
        }

        foreach (string arg in args)
        {
            if (!int.TryParse(arg, out int pid))
            {
                Check(false, $"invalid PID argument: {arg}");
                continue;
            }
            var externalIcon = AppIconService.GetIconForPid(pid);
            Check(externalIcon is BitmapSource externalBitmap && externalBitmap.IsFrozen,
                $"live PID {pid} returns a frozen icon without elevation");
        }
        return failures == 0 ? 0 : 1;
    }
}
