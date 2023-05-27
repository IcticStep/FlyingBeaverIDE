using HtmlParserCore.Services;
using HtmlParserSlovnyk.Domain;
using HtmlParserSlovnyk.Logic.Parsers.Common;

namespace HtmlParserSlovnyk.Logic.Parsers.WordsParser;

public class WordsParserMultiWorker
{
    public WordsParserMultiWorker(Queue<string> wordLinksToWordsQueue, int parallelWorkersCount)
    {
        _wordLinksToWordsQueue = wordLinksToWordsQueue;
        _wordsParserWorker = new();
        CreateParserWorkers(parallelWorkersCount);
    }

    public event Action<WordParsedContent>? OnProgressDone;

    private readonly Queue<string> _wordLinksToWordsQueue;
    private readonly List<ParserWorker<WordParsedContent>> _wordsParserWorker;

    public void StartParsing()
    {
        _wordsParserWorker.ForEach(InitParserWorker);
        
        void InitParserWorker(ParserWorker<WordParsedContent> parserWorker)
        {
            parserWorker.ParserSettings = GetNextLinkToWordsFromWordLinks();
            parserWorker.Start();
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
        if(!_wordLinksToWordsQueue.Any())
            return;

        parserWorker.ParserSettings = GetNextLinkToWordsFromWordLinks();
        parserWorker.Start();
    }
}