using HtmlParserCore.Services;
using HtmlParserSlovnykUA.Parsers.Common;

namespace HtmlParserSlovnykUA.Parsers.WordsParser;

public class WordsParserMultiWorker
{
    public WordsParserMultiWorker(Queue<string> wordLinksToWordsQueue, int parallelWorkersCount)
    {
        _wordLinksToWordsQueue = wordLinksToWordsQueue;
        _parallelWorkersCount = parallelWorkersCount;
        _wordsParserWorker = new();
        CreateParserWorkers(parallelWorkersCount);
    }

    public event Action<WordParsedContent>? OnProgressDone;
    public event Action? OnFinish;

    private readonly int _parallelWorkersCount;
    private readonly Queue<string> _wordLinksToWordsQueue;
    private List<ParserWorker<WordParsedContent>> _wordsParserWorker;
    private List<WordParsedContent?> _words = new();
    private int _parserWorkersInProgress = 0;

    private bool IsAllJobDone => 
        !_wordLinksToWordsQueue.Any() 
        && _parserWorkersInProgress == 0;

    public void StartParsing()
    {
        _wordsParserWorker.ForEach(InitParserWorker);
        
        void InitParserWorker(ParserWorker<WordParsedContent> parserWorker)
        {
            parserWorker.ParserSettings = GetNextLinkToWordsFromWordLinks();
            StartParserWorker(parserWorker);
        }
    }

    private void CreateParserWorkers(int parallelWorkersCount)
    {
        for (var i = 0; i < parallelWorkersCount; i++)
        {
            var parser = new ParserWorker<WordParsedContent>(new WordsParser());
            parser.OnCompleted += result => OnProgressDone?.Invoke(result);
            parser.OnCompleted += _ => HandleParserFinish(parser);
            _wordsParserWorker.Add(parser);
        }
    }

    private WordsParserSettings GetNextLinkToWordsFromWordLinks() => 
        new(_wordLinksToWordsQueue.Dequeue());

    private void HandleParserFinish(ParserWorker<WordParsedContent> parserWorker)
    {
        _parserWorkersInProgress--;
        if (IsAllJobDone)
        {
            OnFinish?.Invoke();
            return;
        }
        
        if(!_wordLinksToWordsQueue.Any())
            return;

        parserWorker.ParserSettings = GetNextLinkToWordsFromWordLinks();
        StartParserWorker(parserWorker);
    }

    private void StartParserWorker(ParserWorker<WordParsedContent> parserWorker)
    {
        parserWorker.Start();
        _parserWorkersInProgress++;
    }
}