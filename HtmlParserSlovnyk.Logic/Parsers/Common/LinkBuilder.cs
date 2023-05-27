using HtmlParserSlovnyk.Logic.Parsers.ContTLinksParser;
using HtmlParserSlovnyk.Logic.Parsers.LettersLinksParser;

namespace HtmlParserSlovnyk.Logic.Parsers.Common;

public class LinkBuilder
{
    public LinkBuilder(string mainDomainUrl) => _mainDomainUrl = mainDomainUrl;
    
    private readonly string _mainDomainUrl;

    public LetterLink ModifyToAbsoluteLink(LetterLink linkData)
    {
        linkData.Link = _mainDomainUrl + linkData.Link;
        return linkData;
    }

    public ContTLink? ModifyToAbsoluteLink(ContTLink? linkWithRelative)
    {
        linkWithRelative.Links = linkWithRelative.Links
            .Select(link => _mainDomainUrl + "/" + link)
            .ToList();
        
        return linkWithRelative;
    }
}