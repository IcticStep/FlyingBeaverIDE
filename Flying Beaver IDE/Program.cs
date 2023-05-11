using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Flying_Beaver_IDE.Services;

namespace Flying_Beaver_IDE
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            SyncfusionActivator.Activate();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormDesign());
        }
    }
}
