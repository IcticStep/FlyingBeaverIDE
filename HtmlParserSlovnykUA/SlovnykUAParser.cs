using System.Text.Json;
using HtmlParserCore.Services;
using HtmlParserSlovnykUA.Parsers.Common;
using HtmlParserSlovnykUA.Parsers.LettersLinksParser;

namespace HtmlParserSlovnykUA;

// ReSharper disable once InconsistentNaming
public class SlovnykUAParser
{
    public SlovnykUAParser()
    {
        _letterLinksParser.OnCompleted += ProceedLetterLinks;
    }

    public event Action<SlovnykUAParser> OnUpdate;
    public event Action<SlovnykUAParser> OnFinish;
    private const string MainDomainUrl = "https://slovnyk.ua";

    private List<LetterLink> _letterLinks = new();
    private readonly LinkBuilder _linkBuilder = new(MainDomainUrl);
    private readonly ParserWorker<IEnumerable<LetterLink>> _letterLinksParser = new(
        new LettersLinksParser(),
        new LettersLinksParserSettings());

    public IReadOnlyList<LetterLink> LetterLinks => _letterLinks;
    public string LetterLinksJson
    {
        get => JsonSerializer.Serialize(_letterLinks);
        set => _letterLinks = JsonSerializer.Deserialize<List<LetterLink>>(value);
    }

    public void StartParsingLetterLinks() 
        => _letterLinksParser.Start();

    private void ProceedLetterLinks(IEnumerable<LetterLink> links)
    {
        _letterLinks = links.Select(_linkBuilder.GetAbsoluteLetterLink).ToList();
        OnUpdate?.Invoke(this);
        OnFinish?.Invoke(this);
    }
}