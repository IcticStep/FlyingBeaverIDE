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

        public MainForm(string path) : this()
        {
            ReadFileIfPossible(path);
            PoemTextBox.Text = _flyingBeaver.PoemText;
        }
        
        private void ReadFileIfPossible(string path)
        {
            var poem = _fileSaver.LoadDataFromFile(path);
            if (poem is null)
                return;
            _flyingBeaver = new(poem);
        }

        private FlyingBeaver _flyingBeaver = new();
        private readonly FileSaver _fileSaver = new();

        private void CreateNewFile(object sender, EventArgs e) =>
            HandleMainMenuButton(() => Process.Start(Application.ExecutablePath));

        private void OpenFile(object sender, EventArgs e)
        {
            var filePath = _fileSaver.ChooseFilePathToOpen();
            if(filePath is null) return;
            HandleMainMenuButton(() => Process.Start(Application.ExecutablePath, filePath));
        }

        private void SaveFile(object sender, EventArgs e)
        {
            var data = _flyingBeaver.Poem;
            HandleMainMenuButton(() => _fileSaver.SaveFileWithDialog(data));
        }

        private void SaveFileAs(object sender, EventArgs e)
        {
            var data = _flyingBeaver.Poem;
            HandleMainMenuButton(() => _fileSaver.SaveFileAsWithDialog(data));
        }

        private void ExitProgram(object sender, EventArgs e) =>
            Application.Exit();

        private void HandleMainMenuButton(Action action)
        {
            action.Invoke();
            backStageView.HideBackStage();
        }

        private void HandleTextChanged(object? sender, EventArgs e)
        {
            var textBox = (RichTextBox)sender!;
            _flyingBeaver.PoemText = textBox.Text;
        }
    }
}