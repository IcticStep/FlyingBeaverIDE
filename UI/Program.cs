using FlyingBeaverIDE.UI.Services;

namespace FlyingBeaverIDE.UI;

internal static class Program
{
    private static readonly SyncfusionActivator _syncfusionActivator = new();
    
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        _syncfusionActivator.Activate();
        ApplicationConfiguration.Initialize();

        if (args.Length == 0)
        {
            Application.Run(new MainForm());
            return;
        }

        var path = FileSaver.UnshieldPath(args[0]);
        Application.Run(new MainForm(path));
    }
}