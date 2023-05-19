using AngleSharp.Html.Dom;
using HtmlParserCore.API;
using HTMLParserCore.Extensions;

namespace HtmlParserSlovnykUA.Parsers.LettersLinksParser;

internal class LettersLinksParser : IParser<IEnumerable<string>>
{
    private const string LetterClassName = "letter";
    
    public IEnumerable<string> Parse(IHtmlDocument document)
    {
        var lettersElements = document.FindClasses(LetterClassName);
        var lettersLinksElements = lettersElements.Select(lettersElement => lettersElement.Children.First());
        var lettersLinks = lettersLinksElements.Select(letter => letter.GetAttribute("href"));
        return lettersLinks;
    }
}