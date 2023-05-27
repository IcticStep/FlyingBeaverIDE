using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using HtmlParserCore.API;
using HTMLParserCore.Extensions;

namespace HtmlParserSlovnyk.Logic.Parsers.ContTLinksParser;

public class ContTLinksParser : IParser<ContTLink>
{
    private const string SubletterLinkClassName = "cont_link";
    
    public ContTLink? Parse(IHtmlDocument document)
    {
        var subletterLinksElements = document.FindClasses(SubletterLinkClassName);
        if (!subletterLinksElements.Any())
            return null;
        var links = GetLinks(subletterLinksElements);
        if (!links.Any())
            return null;
        
        var letter = GetLetterOf(subletterLinksElements);
        return new ContTLink(letter, links.ToList());
    }

    private static IEnumerable<string?> GetLinks(IEnumerable<IElement> subletterLinksElements) => 
        subletterLinksElements.Select(element => element.GetHref());

    private static char GetLetterOf(IHtmlCollection<IElement> subletterLinksElements) => 
        subletterLinksElements.First().TextContent.First();
}