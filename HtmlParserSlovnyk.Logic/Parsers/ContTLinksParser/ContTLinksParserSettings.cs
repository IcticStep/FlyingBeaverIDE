using HtmlParserCore.API;

namespace HtmlParserSlovnyk.Logic.Parsers.ContTLinksParser;

public class ContTLinksParserSettings : IParserSettings
{
    public ContTLinksParserSettings(string url) => 
        URL = url;

    public string URL { get; set; }
}