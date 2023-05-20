using System.Text.Json;
using HtmlParserCore.Services;
using HtmlParserSlovnykUA.Parsers.Common;
using HtmlParserSlovnykUA.Parsers.LettersLinksParser;
using HtmlParserSlovnykUA.Parsers.SublettersLinksParser;

namespace HtmlParserSlovnykUA;

// ReSharper disable once InconsistentNaming
public class SlovnykUAParser
{
    public event Action<SlovnykUAParser, ProgressInfo>? OnProgressDone;
    public event Action<SlovnykUAParser>? OnFinish;
    private const string MainDomainUrl = "https://slovnyk.ua";

    private readonly LinkBuilder _linkBuilder = new(MainDomainUrl);
    private ProgressInfo _currentProgress = null!;

    private List<LetterLink> _letterLinks = new();
    private ParserWorker<IEnumerable<LetterLink>> _letterLinksParser = null!;

    private List<SubletterLink> _subletterLinks = new();
    private ParserWorker<SubletterLink> _subletterLinksParser = null!;
    private Queue<LetterLink> _letterLinksToSubletterQueue = null!;

    public int LetterLinksDataRowsCount => _letterLinks.Count;
    public int SubletterLinksDataRowsCount => _subletterLinks.Sum(
        subletterLink => subletterLink.Links.Count);
    
    public bool CanParseSubletters => _letterLinks.Count > 0;

    public string LetterLinksJson
    {
        get => JsonSerializer.Serialize(_letterLinks);
        set => _letterLinks = JsonSerializer.Deserialize<List<LetterLink>>(value);
    }
    
    public string SubletterLinksJson
    {
        get => JsonSerializer.Serialize(_subletterLinks);
        set => _subletterLinks = JsonSerializer.Deserialize<List<SubletterLink>>(value);
    }

    public void StartParsingLetterLinks()
    {
        _letterLinksParser = new(
            new LettersLinksParser(),
            new LettersLinksParserSettings());
        _letterLinksParser.OnCompleted += ProceedLetterLinks;
        _letterLinksParser.Start();
    }

    public void StartParsingSubletterLinks()
    {
        if (!CanParseSubletters)
            throw new InvalidOperationException();
        
        InitSublettersParsing();

        _currentProgress = new ProgressInfo(_letterLinksToSubletterQueue.Count, 0);
        _subletterLinksParser.ParserSettings = GetNextLinkToSubletterFromLetter();
        _subletterLinksParser.Start();
    }

    private void InitSublettersParsing()
    {
        _subletterLinks.Clear();
        _subletterLinksParser = new(new SubletterLinksParser());
        _letterLinksToSubletterQueue = new(_letterLinks);
        _subletterLinksParser.OnCompleted += ProceedSubletterLinks;
    }

    private SubletterLinksParserSettings GetNextLinkToSubletterFromLetter() 
        => new(_letterLinksToSubletterQueue.Dequeue().Link);

    private void ProceedSubletterLinks(SubletterLink result)
    {
        _subletterLinks.Add(_linkBuilder.ModifyToAbsoluteLink(result));
        SignalSubletterProgress();
        if (_currentProgress.Finished)
        {
            OnFinish?.Invoke(this);
            return;
        }
        
        _subletterLinksParser.ParserSettings = GetNextLinkToSubletterFromLetter();
        _subletterLinksParser.Start();
    }

    private void SignalSubletterProgress()
    {
        _currentProgress = ProgressInfo.WithIncreasedProgress(_currentProgress);
        OnProgressDone?.Invoke(this, _currentProgress);
    }

    private void ProceedLetterLinks(IEnumerable<LetterLink> links)
    {
        _letterLinks = links.Select(_linkBuilder.ModifyToAbsoluteLink).ToList();
        OnProgressDone?.Invoke(this, new ProgressInfo(1, 1));
        OnFinish?.Invoke(this);
    }
}