namespace HtmlParserSlovnykUA.Parsers.LettersLinksParser;

[Serializable]
public class LetterLink
{
    public LetterLink(char letter, string link)
    {
        Letter = letter;
        Link = link;
    }

    public char Letter { get; set; }
    public string Link { get; set; }
}