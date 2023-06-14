using Syncfusion.Windows.Forms.Tools;
using FlyingBeaverIDE.Logic;
using FlyingBeaverIDE.UI.Services;
using EventArgs = System.EventArgs;

namespace FlyingBeaverIDE.UI
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            FinishInitializingCoreComponents();
            DebugConsole.Init();

            var configurationProvider = new ConfigurationProvider();
            var dataBaseCredentials = configurationProvider.GetDataBaseCredentials();
            var localAccentuationsSavePath = configurationProvider.GetLocalAccentuationsSavePath;
            _flyingBeaver = new FlyingBeaver(dataBaseCredentials, localAccentuationsSavePath);
            _fileSaver = new(_flyingBeaver);
            _backStageMenu = new(_fileSaver, backStageView);
            _flyingBeaver.OnRhythmResult += result => Console.WriteLine(result.ToString());
            _rhythmSelector = new(_flyingBeaver.AvailableRhythms, RhythmsComboBox);
            _rhythmSelector.OnUpdated += rhythm => _flyingBeaver.CurrentRhythm = rhythm;
            _flyingBeaver.OnRhythmLoaded += rhythm => _rhythmSelector.Set(rhythm);
        }

        public MainForm(string? path) : this()
        {
            _flyingBeaver.LoadFromFile(path);
            ShowPoemText();

            void ShowPoemText() =>
                PoemTextBox.Text = _flyingBeaver.PoemText;
        }

        private readonly FlyingBeaver _flyingBeaver;
        private readonly FileSaver _fileSaver;
        private readonly BackStageMenu _backStageMenu;
        private readonly RhythmSelector _rhythmSelector;

        private void CreateNewFile(object sender, EventArgs e) =>
            _backStageMenu.CreateNewFile();

        private void OpenFile(object sender, EventArgs e) =>
            _backStageMenu.OpenFile();

        private void SaveFile(object sender, EventArgs e) =>
            _backStageMenu.SaveFile();

        private void SaveFileAs(object sender, EventArgs e) =>
            _backStageMenu.SaveFileAs();

        private void ExitProgram(object sender, EventArgs e) =>
            _backStageMenu.ExitProgram();

        private void HandleTextChanged(object? sender, EventArgs e)
        {
            var textBox = (RichTextBox)sender!;
            _flyingBeaver.PoemText = textBox.Text;
        }

        private void HandleClosingAttempt(object sender, FormClosingEventArgs e) =>
            _fileSaver.TrySaveOnClose(e);
    }
}