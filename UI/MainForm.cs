using Syncfusion.Windows.Forms.Tools;
using System.Diagnostics;
using FlyingBeaverIDE.Logic;
using FlyingBeaverIDE.UI.Services;
using Action = System.Action;
using EventArgs = System.EventArgs;

namespace FlyingBeaverIDE.UI
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            FinishInitializingCoreComponents();
            SubscribeOnChanges();
        }

        public MainForm(string path) : this()
        {
            ReadFileIfPossible(path);
            ShowPoemText();
            SubscribeOnChanges();

            void ShowPoemText() =>
                PoemTextBox.Text = _flyingBeaver.PoemText;
        }

        private void SubscribeOnChanges() => 
            _flyingBeaver.OnUpdated += () => _fileSaver.SignalUserInput();

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
            if (filePath is null) return;
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
            HandleMainMenuButton(() => _fileSaver.TrySaveFileAsWithDialog(data));
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

        private void HandleClosingAttempt(object sender, FormClosingEventArgs e)
        {
            if (_fileSaver.AllChangesSaved)
                return;

            var choice = AskSaveBeforeClosing();
            if (choice == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }

            if (choice == DialogResult.No)
                return;

            var saved = _fileSaver.TrySaveFileAsWithDialog(_flyingBeaver.Poem);
            if (!saved)
                e.Cancel = true;
        }

        private static DialogResult AskSaveBeforeClosing() =>
            MessageBox.Show(
                "Зберегти зміни?",
                "Незбереженні зміни",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);
    }
}