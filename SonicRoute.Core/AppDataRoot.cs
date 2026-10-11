using System;
using System.IO;

namespace SonicRoute.Core
{
    /// <summary>Shared data directory for released Lite, Legacy and Store editions.</summary>
    public static class AppDataRoot
    {
        public static string DirectoryPath { get; } = Resolve();

        private static string Resolve()
        {
            // Resolve only; the existing configuration/rule writers create directories when needed.
            return ResolveDirectory(Environment.GetEnvironmentVariable("SONICROUTE_DATA_DIRECTORY"),
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
        }

        internal static string ResolveDirectory(string? overridePath, string localAppData)
        {
            // An explicit absolute override supports isolated tooling; normal installs keep existing user data.
            string value = overridePath ?? Path.Combine(localAppData, "SonicRoute");
#if NET48
            if (!Path.IsPathRooted(value) || string.IsNullOrEmpty(Path.GetPathRoot(value))
                || !Path.GetPathRoot(value)!.EndsWith(@"\", StringComparison.Ordinal))
#else
            if (!Path.IsPathFullyQualified(value))
#endif
                throw new InvalidOperationException("SonicRoute data directory must be absolute.");
            return Path.GetFullPath(value);
        }
    }
}
