using HtmlParserCore.API;

namespace HtmlParserSlovnykUA.Parsers.ContTLinksParser;

public class ContTLinksParserSettings : IParserSettings
{
    public ContTLinksParserSettings(string url) => 
        URL = url;

    public string URL { get; set; }
}