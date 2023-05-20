using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using HtmlParserCore.API;
using HTMLParserCore.Extensions;

namespace HtmlParserSlovnykUA.Parsers.SublettersLinksParser;

public class SubletterLinksParser : IParser<SubletterLink>
{
    private const string SubletterLinkClassName = "cont_link";
    
    public SubletterLink Parse(IHtmlDocument document)
    {
        var subletterLinksElements = document.FindClasses(SubletterLinkClassName);
        var links = GetLinks(subletterLinksElements);
        var letter = GetLetterOf(subletterLinksElements);
        return new SubletterLink(letter, links!);
    }

    private static IEnumerable<string?> GetLinks(IEnumerable<IElement> subletterLinksElements) => 
        subletterLinksElements.Select(element => element.GetHref());

    private static char GetLetterOf(IHtmlCollection<IElement> subletterLinksElements) => 
        subletterLinksElements.First().TextContent.First();
}