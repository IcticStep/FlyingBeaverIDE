using HtmlParserCore.Services;
using HtmlParserSlovnykUA.Parsers.LettersLinksParser;

namespace HtmlParserSlovnykUA;

// ReSharper disable once InconsistentNaming
public class SlnovnykUAParser
{
    public SlnovnykUAParser()
    {
        _letterLinksParser.OnCompleted += ProceedLetterLinks;
    }
    
    public event Action<IEnumerable<string>> OnLetterLinksGot;
    private const string MainDomenURL = "https://slovnyk.ua";

    private readonly ParserWorker<IEnumerable<string>> _letterLinksParser = new(
        new LettersLinksParser(),
        new LettersLinksParserSettings());
    
    public void StartParsingLetterLinks() 
        => _letterLinksParser.Start();

    private void ProceedLetterLinks(IEnumerable<string> links)
    {
        var absoluteLinks = GetAbsoluteLinks(links);
        OnLetterLinksGot?.Invoke(absoluteLinks);
    }

    private IEnumerable<string> GetAbsoluteLinks(IEnumerable<string> relativeLinks) => 
        relativeLinks.Select(link => MainDomenURL + link);
}