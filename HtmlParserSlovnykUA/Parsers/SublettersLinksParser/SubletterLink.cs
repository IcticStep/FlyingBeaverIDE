namespace HtmlParserSlovnykUA.Parsers.SublettersLinksParser;

[Serializable]
public class SubletterLink
{
    public SubletterLink(char letter, IEnumerable<string> link)
    {
        Letter = letter;
        Links = link.ToList();
    }

    public char Letter { get; set; }
    public List<string> Links { get; set; }
}