using HtmlParserCore.API;

namespace HtmlParserSlovnykUA.Parsers.WordsParser;

public class WordsParserSettings : IParserSettings
{
    public WordsParserSettings(string url) => 
        URL = url;
    public string URL { get; set; }
}