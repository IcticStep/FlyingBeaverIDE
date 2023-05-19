using HtmlParserSlovnykUA;

namespace ParserHTML;

internal static class Program
{
    private static readonly SlnovnykUAParser _parser = new SlnovnykUAParser();
    private static List<string> _links;
    private static void Main()
    {
        _parser.OnLetterLinksGot += links => _links = links.ToList();
        _parser.StartParsingLetterLinks();

        // ReSharper disable once EmptyEmbeddedStatement
        while (_links is null);

        Console.WriteLine("Links:");
        _links.ForEach(Console.WriteLine);
    }
}