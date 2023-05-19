using HtmlParserCore.API;

namespace HtmlParserSlovnykUA.Parsers.LettersLinksParser;

public class LettersLinksParserSettings : IParserSettings
{
    public string URL { get; set; } = @"https://slovnyk.ua/index.php";
}