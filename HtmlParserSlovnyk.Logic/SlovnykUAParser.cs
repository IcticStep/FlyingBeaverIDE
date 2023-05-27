using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using HtmlParserCore.Services;
using HtmlParserSlovnyk.Logic.Parsers.Common;
using HtmlParserSlovnyk.Logic.Parsers.ContTLinksParser;
using HtmlParserSlovnyk.Logic.Parsers.LettersLinksParser;
using HtmlParserSlovnyk.Logic.Parsers.WordsParser;

#pragma warning disable CS8619
#pragma warning disable CS8601

namespace HtmlParserSlovnyk.Logic;

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
    private List<WordParsedContent?> _words = new();
    
    private ParserWorker<IEnumerable<LetterLink>> _letterLinksParserWorker = null!;
    private ParserWorker<ContTLink> _contTLinksParserWorker = null!;
    private WordsParserMultiWorker _wordsParserWorker = null!;
    
    private Queue<LetterLink> _letterLinksToSubletterQueue = null!;
    private Queue<string> _subletterLinksToWordsQueue = null!;
    private Queue<string> _wordLinksToWordsQueue = null!;

    public int LetterLinksDataRowsCount => _letterLinks.Count;
    public int SubletterLinksDataRowsCount => _subletterLinks.Sum(
        linkContainer => linkContainer.Links.Count);
    public int WordsLinksDataRowsCount => _wordsLinks.Sum(
        linkContainer => linkContainer.Links.Count);
    public int WordsDataRowsCount => _words.Count;
    
    public bool CanParseSubletters => _letterLinks.Count > 0;
    public bool CanParseWordsLinks => _subletterLinks.Count > 0;
    public bool CanParseWords => _wordsLinks.Count > 0;

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

    public string WordsJson 
    { 
        get => JsonSerializer.Serialize(_words, _jsonOptions);
        set => _words = JsonSerializer.Deserialize<List<WordParsedContent>>(value, _jsonOptions); 
    }

    public void StartParsingLetterLinks()
    {
        _letterLinksParserWorker = new(
            new LettersLinksParser(),
            new LettersLinksParserSettings());
        _letterLinksParserWorker.OnCompleted += ProceedLetterLinks;
        _letterLinksParserWorker.Start();
    }

    public void StartParsingSubletterLinks()
    {
        if (!CanParseSubletters)
            throw new InvalidOperationException();
        
        InitSublettersParsing();

        _currentProgress = new ProgressInfo(_letterLinksToSubletterQueue.Count, 0);
        _contTLinksParserWorker.ParserSettings = GetNextLinkToSubletterFromLetter();
        _contTLinksParserWorker.Start();
    }
    
    public void StartParsingWordsLinks()
    {
        if (!CanParseWordsLinks)
            throw new InvalidOperationException();
        
        InitWordsLinksParsing();

        _currentProgress = new ProgressInfo(_subletterLinksToWordsQueue.Count, 0);
        _contTLinksParserWorker.ParserSettings = GetNextLinkToWordsLinksFromSubletter();
        _contTLinksParserWorker.Start();
    }
    
    public void StartParsingWords(int parallelWorkersAmount)
    {
        if (parallelWorkersAmount <= 0)
            throw new ArgumentException("Can't start 0 or less workers!");
        
        if (!CanParseWords)
            throw new InvalidOperationException();
        
        InitWordsParsing(parallelWorkersAmount);
        _currentProgress = new ProgressInfo(_wordLinksToWordsQueue.Count, 0);
        _wordsParserWorker.StartParsing();
    }

    private void InitSublettersParsing()
    {
        _subletterLinks.Clear();
        _contTLinksParserWorker = new(new ContTLinksParser());
        _letterLinksToSubletterQueue = new(_letterLinks);
        _contTLinksParserWorker.OnCompleted += ProceedSubletterContTLinks;
    }

    private void InitWordsLinksParsing()
    {
        _wordsLinks.Clear();
        _contTLinksParserWorker = new(new ContTLinksParser());
        _subletterLinksToWordsQueue = new(_subletterLinks.SelectMany(linkGroup => linkGroup.Links));
        _contTLinksParserWorker.OnCompleted += ProceedWordsLinksContTLinks;
    }

    private void InitWordsParsing(int parallelWorkersAmount)
    {
        _words.Clear();
        _wordLinksToWordsQueue = new(_wordsLinks.SelectMany(linkGroup => linkGroup.Links));
        _wordsParserWorker = new(_wordLinksToWordsQueue, parallelWorkersAmount);
        _wordsParserWorker.OnProgressDone += ProceedWords;
    }

    private ContTLinksParserSettings GetNextLinkToSubletterFromLetter() => 
        new(_letterLinksToSubletterQueue.Dequeue().Link);

    private ContTLinksParserSettings GetNextLinkToWordsLinksFromSubletter() => 
        new(_subletterLinksToWordsQueue.Dequeue());

    private WordsParserSettings GetNextLinkToWordsFromWordLinks() => 
        new(_wordLinksToWordsQueue.Dequeue());

    private void ProceedLetterLinks(IEnumerable<LetterLink> links)
    {
        _letterLinks = links.Select(_linkBuilder.ModifyToAbsoluteLink).ToList();
        OnProgressDone?.Invoke(this, new ProgressInfo(1, 1));
        OnFinish?.Invoke(this);
    }

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
        
        _contTLinksParserWorker.ParserSettings = GetNextLinkToSubletterFromLetter();
        _contTLinksParserWorker.Start();
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
        
        _contTLinksParserWorker.ParserSettings = GetNextLinkToWordsLinksFromSubletter();
        _contTLinksParserWorker.Start();
    }

    private void ProceedWords(WordParsedContent? result)
    {
        if(result is not null)
            _words.Add(result);
        
        SignalProgress();

        if (!_currentProgress.Finished) return;
        OnFinish?.Invoke(this);
    }

    private void SignalProgress()
    {
        _currentProgress = ProgressInfo.WithIncreasedProgress(_currentProgress);
        OnProgressDone?.Invoke(this, _currentProgress);
    }
}