using HtmlParserSlovnykUA.Parsers.LettersLinksParser;

namespace HtmlParserSlovnykUA.Parsers.Common;

public class LinkBuilder
{
    public LinkBuilder(string mainDomainUrl) => _mainDomainUrl = mainDomainUrl;
    
    private readonly string _mainDomainUrl;

    public LetterLink GetAbsoluteLetterLink(LetterLink linkWithRelative) => 
        new(linkWithRelative.Letter, _mainDomainUrl + linkWithRelative);
}