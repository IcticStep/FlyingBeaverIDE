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
    private const string WordLinksFileName = "WordLinks";
    private const string WordFileName = "Words";
    private const string ErrorHeader = "Помилка";
    private const int WordsParallelWorkersCount = 100;

    private readonly SlovnykUAParser _slovnykUaParser = new();
    private List<Button> _buttons;
    private readonly FileSaver _fileSaver = new();

    public MainForm()
    {
        InitializeComponent();
        _slovnykUaParser.OnProgressDone += (_, progress) => UpdateProgressInfo(progress);
        _slovnykUaParser.OnProgressDone += (_, _) => UpdateRowsCounters();
        _slovnykUaParser.OnFinish += _ => EnableButtons();
        _slovnykUaParser.OnFinish += _ => UpdateRowsCounters();
        InitButtonsList();
        UpdateRowsCounters();
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
        //DisableButtons();
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
        //DisableButtons();
        _slovnykUaParser.StartParsingSubletterLinks();
    }

    private void ParseWordsLinks(object sender, EventArgs e)
    {
        if (!_slovnykUaParser.CanParseWordsLinks)
        {
            ShowError("Неможливо виконати парсинг. Необхідні посилання на підрозділи букв.");
            return;
        }

        CurrentOperationName.Text = "Парсинг ссилок на слова";
        //DisableButtons();
        _slovnykUaParser.StartParsingWordsLinks();
    }

    private void ParseWords(object sender, EventArgs e)
    {
        if (!_slovnykUaParser.CanParseWords)
        {
            ShowError("Неможливо виконати парсинг. Необхідні посилання на слова.");
            return;
        }

        CurrentOperationName.Text = "Парсинг самих слів";
        //DisableButtons();
        _slovnykUaParser.StartParsingWords(WordsParallelWorkersCount);
    }

    private void UpdateProgressInfo(ProgressInfo progressInfo)
    {
        ProgressOperationsCounter.Text = progressInfo.ToString();
        ProgressBar.Value = (int)progressInfo.FancyProgressPercents;
    }

    private static void ShowError(string message) =>
        MessageBox.Show(message, ErrorHeader, MessageBoxButtons.OK, MessageBoxIcon.Error);

    private void UpdateRowsCounters()
    {
        LettersDataRows.Text = RowsLinkDataCountLabel + _slovnykUaParser.LetterLinksDataRowsCount;
        SublettersDataRows.Text = RowsLinkDataCountLabel + _slovnykUaParser.SubletterLinksDataRowsCount;
        WordLinksDataRows.Text = RowsLinkDataCountLabel + _slovnykUaParser.WordsLinksDataRowsCount;
        WordsDataRows.Text = RowsDataCountLabel + _slovnykUaParser.WordsDataRowsCount;
    }

    private void EnableButtons() =>
        _buttons.ForEach(button => button.Enabled = true);

    private void DisableButtons() =>
        _buttons.ForEach(button => button.Enabled = false);

    private void LoadLettersData(object sender, EventArgs e)
    {
        var loaded = _fileSaver.LoadData(LettersFileName);
        if (string.IsNullOrWhiteSpace(loaded))
            return;

        _slovnykUaParser.LetterLinksJson = loaded;
        UpdateRowsCounters();
    }

    private void LoadSublettersData(object sender, EventArgs e)
    {
        var loaded = _fileSaver.LoadData(SublettersFileName);
        if (string.IsNullOrWhiteSpace(loaded))
            return;

        _slovnykUaParser.SubletterLinksJson = loaded;
        UpdateRowsCounters();
    }

    private void LoadWordsLinksData(object sender, EventArgs e)
    {
        var loaded = _fileSaver.LoadData(WordLinksFileName);
        if (string.IsNullOrWhiteSpace(loaded))
            return;

        _slovnykUaParser.WordLinksJson = loaded;
        UpdateRowsCounters();
    }

    private void LoadWordsData(object sender, EventArgs e)
    {
        var loaded = _fileSaver.LoadData(WordFileName);
        if (string.IsNullOrWhiteSpace(loaded))
            return;

        _slovnykUaParser.WordsJson = loaded;
        UpdateRowsCounters();
    }

    private void SaveLettersLinksData(object sender, EventArgs e) =>
        _fileSaver.SaveData(LettersFileName, _slovnykUaParser.LetterLinksJson);

    private void SaveSublettersData(object sender, EventArgs e) =>
        _fileSaver.SaveData(SublettersFileName, _slovnykUaParser.SubletterLinksJson);

    private void SaveWordLinksData(object sender, EventArgs e) =>
        _fileSaver.SaveData(WordLinksFileName, _slovnykUaParser.WordLinksJson);

    private void SaveWordsData(object sender, EventArgs e) =>
        _fileSaver.SaveData(WordFileName, _slovnykUaParser.WordsJson);
}