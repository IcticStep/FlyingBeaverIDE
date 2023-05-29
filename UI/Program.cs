using FlyingBeaverIDE.UI.Services;

namespace FlyingBeaverIDE.UI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        SyncfusionActivator.Activate();
        ApplicationConfiguration.Initialize();

        if (args.Length == 0)
        {
            Application.Run(new MainForm());
            return;
        }
        
        Application.Run(new MainForm(args[0]));
    }
}