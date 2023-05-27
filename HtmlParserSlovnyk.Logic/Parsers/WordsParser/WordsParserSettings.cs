using HtmlParserCore.API;

namespace HtmlParserSlovnyk.Logic.Parsers.WordsParser;

public class WordsParserSettings : IParserSettings
{
    public WordsParserSettings(string url) => 
        URL = url;
    public string URL { get; set; }
}