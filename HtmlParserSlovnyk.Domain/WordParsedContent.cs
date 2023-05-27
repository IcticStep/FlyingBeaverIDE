namespace HtmlParserSlovnyk.Logic.Parsers.WordsParser;

[Serializable]
public class WordParsedContent
{
    public WordParsedContent(string word, string parsedContent)
    {
        Word = word;
        ParsedContent = parsedContent;
    }

    public string Word { get; set; }
    public string ParsedContent { get; set; }
}