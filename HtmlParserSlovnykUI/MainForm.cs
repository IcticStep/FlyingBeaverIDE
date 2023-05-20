using HtmlParserSlovnykUA;
using HtmlParserSlovnykUA.Parsers.Common;
using HtmlParserSlovnykUA.Parsers.LettersLinksParser;

namespace HtmlParserSlovnykUI;

public partial class MainForm : Form
{
    private const string RowsLinkDataCountLabel = "Кількість посилань: ";
    private const string RowsDataCountLabel = "Кількість записів: ";
    private const string LettersFileName = "LettersLinks";
    private const string SublettersFileName = "SublettersLinks";

    private readonly SlovnykUAParser _slovnykUaParser = new();
    private List<Button> _buttons;
    private readonly FileSaver _fileSaver = new();

    public MainForm()
    {
        InitializeComponent();
        _slovnykUaParser.OnProgressDone += (_, progress) => UpdateProgressInfo(progress);
        _slovnykUaParser.OnFinish += _ => EnableButtons();
        _slovnykUaParser.OnFinish += _ => UpdateView();
        InitButtonsList();
        UpdateView();
    }

    private void InitButtonsList()
    {
        _buttons = new()
        {
            LettersParseButton,
            LettersOpenButton,
            LettersSaveButton,
            SublettersParseButton,
            SublettersOpenButton,
            SublettersSaveButton,
            WordsLinksParseButton,
            WordsLinksOpenButton,
            WordsLinksSaveButton,
            WordsParseButton,
            WordsOpenButton,
            WordsSaveButton
        };
    }

    private void ParseLetters(object sender, EventArgs e)
    {
        DisableButtons();
        CurrentOperationName.Text = "Парсинг букв";
        ProgressOperationsCounter.Text = "0/1";
        _slovnykUaParser.StartParsingLetterLinks();
    }

    private void ParseSubletters(object sender, EventArgs e)
    {
        if (!_slovnykUaParser.CanParseSubletters)
        {
            ShowError("Неможливо виконати парсинг. Необхідні посилання на букви.");
            return;
        }

        CurrentOperationName.Text = "Парсинг підрозділів букв";
        DisableButtons();
        _slovnykUaParser.StartParsingSubletterLinks();
    }

    private void UpdateProgressInfo(ProgressInfo progressInfo)
    {
        ProgressOperationsCounter.Text = progressInfo.ToString();
        ProgressBar.Value = (int)progressInfo.FancyProgressPercents;
    }

    private static void ShowError(string message) =>
        MessageBox.Show(message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

    private void UpdateView()
    {
        LettersDataRows.Text = RowsLinkDataCountLabel + _slovnykUaParser.LetterLinksDataRowsCount;
        SublettersDataRows.Text = RowsLinkDataCountLabel + _slovnykUaParser.SubletterLinksDataRowsCount;
        WordLinksDataRows.Text = RowsLinkDataCountLabel + 0;
        WordsDataRows.Text = RowsDataCountLabel + 0;
    }

    private void EnableButtons() =>
        _buttons.ForEach(button => button.Enabled = true);

    private void DisableButtons() =>
        _buttons.ForEach(button => button.Enabled = false);

    private void SaveLettersLinksData(object sender, EventArgs e) =>
        _fileSaver.SaveData(LettersFileName, _slovnykUaParser.LetterLinksJson);

    private void LoadLettersData(object sender, EventArgs e)
    {
        var loaded = _fileSaver.LoadData(LettersFileName);
        if (string.IsNullOrWhiteSpace(loaded))
            return;

        _slovnykUaParser.LetterLinksJson = loaded;
        UpdateView();
    }



    private void LoadSublettersData(object sender, EventArgs e)
    {
        var loaded = _fileSaver.LoadData(SublettersFileName);
        if (string.IsNullOrWhiteSpace(loaded))
            return;

        _slovnykUaParser.SubletterLinksJson = loaded;
        UpdateView();
    }

    private void SaveSublettersData(object sender, EventArgs e) =>
        _fileSaver.SaveData(SublettersFileName, _slovnykUaParser.SubletterLinksJson);
}