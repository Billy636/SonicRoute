using System.Runtime.InteropServices;

namespace SonicRoute.StoreInterop;

public static class NativePackageIdentity
{
    [DllImport("kernel32.dll", ExactSpelling = true)]
    private static extern int GetCurrentPackageFullName(ref uint length, IntPtr buffer);

    public static bool IsPackaged()
    {
        uint length = 0;
        int error = GetCurrentPackageFullName(ref length, IntPtr.Zero);
        return error == 122 && length > 0; // ERROR_INSUFFICIENT_BUFFER; no identity returns 15700.
    }
}
