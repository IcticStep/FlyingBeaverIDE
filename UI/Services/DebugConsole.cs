using System.Runtime.InteropServices;
using System.Text;

namespace FlyingBeaverIDE.UI.Services;

public static class DebugConsole
{
    public static void Init()
    {
        AllocConsole();
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool AllocConsole();
}