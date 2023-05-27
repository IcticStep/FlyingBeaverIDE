using HtmlParserCore.API;

namespace HtmlParserSlovnyk.Logic.Parsers.LettersLinksParser;

public class LettersLinksParserSettings : IParserSettings
{
    public string URL { get; set; } = @"https://slovnyk.ua/index.php";
}