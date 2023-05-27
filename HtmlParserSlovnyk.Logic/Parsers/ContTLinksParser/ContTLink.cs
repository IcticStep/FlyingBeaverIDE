namespace HtmlParserSlovnyk.Logic.Parsers.ContTLinksParser;

[Serializable]
public class ContTLink
{
    public ContTLink(char letter, List<string> links)
    {
        Letter = letter;
        Links = links.ToList();
    }

    public char Letter { get; set; }
    public List<string> Links { get; set; }
}