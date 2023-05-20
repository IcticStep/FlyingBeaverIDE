using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using HtmlParserCore.Services;
using HtmlParserSlovnykUA.Parsers.Common;
using HtmlParserSlovnykUA.Parsers.ContTLinksParser;
using HtmlParserSlovnykUA.Parsers.LettersLinksParser;

#pragma warning disable CS8619
#pragma warning disable CS8601

namespace HtmlParserSlovnykUA;

// ReSharper disable once InconsistentNaming
public class SlovnykUAParser
{
    public event Action<SlovnykUAParser, ProgressInfo>? OnProgressDone;
    public event Action<SlovnykUAParser>? OnFinish;
    private const string MainDomainUrl = @"https://slovnyk.ua";

    private readonly LinkBuilder _linkBuilder = new(MainDomainUrl);
    private ProgressInfo _currentProgress = null!;
    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
        WriteIndented = true
    };

    private List<LetterLink> _letterLinks = new();
    private List<ContTLink?> _subletterLinks = new();
    private List<ContTLink> _wordsLinks = new();
    
    private ParserWorker<IEnumerable<LetterLink>> _letterLinksParser = null!;
    private ParserWorker<ContTLink> _contTLinksParser = null!;
    
    private Queue<LetterLink> _letterLinksToSubletterQueue = null!;
    private Queue<string> _subletterLinksToWordsQueue = null!;

    public int LetterLinksDataRowsCount => _letterLinks.Count;
    public int SubletterLinksDataRowsCount => _subletterLinks.Sum(
        linkContainer => linkContainer.Links.Count);
    public int WordsLinksDataRowsCount => _wordsLinks.Sum(
        linkContainer => linkContainer.Links.Count);
    
    public bool CanParseSubletters => _letterLinks.Count > 0;
    public bool CanParseWordsLinks => _subletterLinks.Count > 0;

    public string LetterLinksJson
    {
        get => JsonSerializer.Serialize(_letterLinks, _jsonOptions);
        set => _letterLinks = JsonSerializer.Deserialize<List<LetterLink>>(value, _jsonOptions);
    }
    
    public string SubletterLinksJson
    {
        get => JsonSerializer.Serialize(_subletterLinks, _jsonOptions);
        set => _subletterLinks = JsonSerializer.Deserialize<List<ContTLink>>(value, _jsonOptions);
    }
    
    public string WordLinksJson
    {
        get => JsonSerializer.Serialize(_wordsLinks, _jsonOptions);
        set => _wordsLinks = JsonSerializer.Deserialize<List<ContTLink>>(value, _jsonOptions);
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
        _contTLinksParser.ParserSettings = GetNextLinkToSubletterFromLetter();
        _contTLinksParser.Start();
    }
    
    public void StartParsingWordsLinks()
    {
        if (!CanParseWordsLinks)
            throw new InvalidOperationException();
        
        InitWordsLinksParsing();

        _currentProgress = new ProgressInfo(_subletterLinksToWordsQueue.Count, 0);
        _contTLinksParser.ParserSettings = GetNextLinkToWordsLinksFromSubletter();
        _contTLinksParser.Start();
    }

    private void InitSublettersParsing()
    {
        _subletterLinks.Clear();
        _contTLinksParser = new(new ContTLinksParser());
        _letterLinksToSubletterQueue = new(_letterLinks);
        _contTLinksParser.OnCompleted += ProceedSubletterContTLinks;
    }
    
    private void InitWordsLinksParsing()
    {
        _wordsLinks.Clear();
        _contTLinksParser = new(new ContTLinksParser());
        _subletterLinksToWordsQueue = new(_subletterLinks.SelectMany(linkGroup => linkGroup.Links));
        _contTLinksParser.OnCompleted += ProceedWordsLinksContTLinks;
    }

    private ContTLinksParserSettings GetNextLinkToSubletterFromLetter() 
        => new(_letterLinksToSubletterQueue.Dequeue().Link);

    private ContTLinksParserSettings GetNextLinkToWordsLinksFromSubletter() 
        => new(_subletterLinksToWordsQueue.Dequeue());

    private void ProceedSubletterContTLinks(ContTLink? result)
    {
        if(result is not null)
            _subletterLinks.Add(_linkBuilder.ModifyToAbsoluteLink(result));
        
        SignalProgress();
        if (_currentProgress.Finished)
        {
            OnFinish?.Invoke(this);
            return;
        }
        
        _contTLinksParser.ParserSettings = GetNextLinkToSubletterFromLetter();
        _contTLinksParser.Start();
    }
    
    private void ProceedWordsLinksContTLinks(ContTLink? result)
    {
        if(result is not null)
            _wordsLinks.Add(_linkBuilder.ModifyToAbsoluteLink(result));
        
        SignalProgress();
        if (_currentProgress.Finished)
        {
            OnFinish?.Invoke(this);
            return;
        }
        
        _contTLinksParser.ParserSettings = GetNextLinkToWordsLinksFromSubletter();
        _contTLinksParser.Start();
    }

    private void SignalProgress()
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