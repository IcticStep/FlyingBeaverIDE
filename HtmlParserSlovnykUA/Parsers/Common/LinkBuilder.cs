using HtmlParserSlovnykUA.Parsers.LettersLinksParser;
using HtmlParserSlovnykUA.Parsers.SublettersLinksParser;

namespace HtmlParserSlovnykUA.Parsers.Common;

public class LinkBuilder
{
    public LinkBuilder(string mainDomainUrl) => _mainDomainUrl = mainDomainUrl;
    
    private readonly string _mainDomainUrl;

    public LetterLink ModifyToAbsoluteLink(LetterLink linkData)
    {
        linkData.Link = _mainDomainUrl + linkData.Link;
        return linkData;
    }

    public SubletterLink ModifyToAbsoluteLink(SubletterLink linkWithRelative)
    {
        linkWithRelative.Links = linkWithRelative.Links
            .Select(link => _mainDomainUrl + link)
            .ToList();
        
        return linkWithRelative;
    }
}