using System.Runtime.InteropServices;
using System.ComponentModel;

namespace SonicRoute.StoreInterop;

public static class NativePackageIdentity
{
    [DllImport("kernel32.dll", ExactSpelling = true)]
    private static extern int GetCurrentPackageFullName(ref uint length, IntPtr buffer);

    public static bool IsPackaged()
    {
        uint length = 0;
        int error = GetCurrentPackageFullName(ref length, IntPtr.Zero);
        return InterpretResult(error, length);
    }

    internal static bool InterpretResult(int error, uint length)
    {
        if (error == 15700) return false; // APPMODEL_ERROR_NO_PACKAGE
        if (error == 122 && length > 0) return true; // ERROR_INSUFFICIENT_BUFFER
        // Detection failures must never turn a Store startup change into a Run-key write.
        throw new Win32Exception(error, "Unable to determine SonicRoute package identity.");
    }
}
