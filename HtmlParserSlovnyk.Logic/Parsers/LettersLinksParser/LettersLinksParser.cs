using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using HtmlParserCore.API;
using HTMLParserCore.Extensions;

namespace HtmlParserSlovnyk.Logic.Parsers.LettersLinksParser;

internal class LettersLinksParser : IParser<IEnumerable<LetterLink>>
{
    private const string LetterClassName = "letter";

    public IEnumerable<LetterLink> Parse(IHtmlDocument document)
    {
        var lettersElements = document.FindClasses(LetterClassName);
        var lettersLinksElements = GetLettersLinksElements(lettersElements);
        return lettersLinksElements.Select(ConvertToLetterLink);
    }

    private static IEnumerable<IElement> GetLettersLinksElements(IEnumerable<IElement> lettersElements) =>
        lettersElements.Select(lettersElement =>
            lettersElement.Children.First());

    private static LetterLink ConvertToLetterLink(IElement letterLink)
    {
        var letter = letterLink.TextContent.First();
        var link = letterLink.GetHref();
        return new LetterLink(letter, link!);
    }
}