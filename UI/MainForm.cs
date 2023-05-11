using Syncfusion.Windows.Forms.Tools;
using System.Diagnostics;
using FlyingBeaverIDE.Logic;
using FlyingBeaverIDE.UI.Services;
using Action = System.Action;

namespace FlyingBeaverIDE.UI
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private FlyingBeaver _flyingBeaver = new();
        private FileSaver _fileSaver = new();

        private void CreateNewFile(object sender, EventArgs e) =>
            HandleMainMenuButton(() => Process.Start(Application.ExecutablePath));

        private void OpenFile(object sender, EventArgs e)
        {

        }

        private void SaveFile(object sender, EventArgs e)
        {
            var data = _flyingBeaver.GetSaveDataJSON();
            HandleMainMenuButton(() => _fileSaver.SaveFile(data));
        }

        private void SaveFileAs(object sender, EventArgs e)
        {
            var data = _flyingBeaver.GetSaveDataJSON();
            HandleMainMenuButton(() => _fileSaver.SaveFileAs(data));
        }

        private void ExitProgram(object sender, EventArgs e) =>
            Application.Exit();

        private void HandleMainMenuButton(Action action)
        {
            action.Invoke();
            backStageView.HideBackStage();
        }
    }
}