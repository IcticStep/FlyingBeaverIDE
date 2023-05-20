using HtmlParserCore.API;

namespace HtmlParserSlovnykUA.Parsers.SublettersLinksParser;

public class SubletterLinksParserSettings : IParserSettings
{
    public SubletterLinksParserSettings(string url) => 
        URL = url;

    public string URL { get; set; }
}