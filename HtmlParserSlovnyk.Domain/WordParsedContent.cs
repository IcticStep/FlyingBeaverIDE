using System.Diagnostics.CodeAnalysis;

namespace HtmlParserSlovnyk.Domain;

[Serializable]
public class WordParsedContent
{
    public WordParsedContent(string word, string parsedContent)
    {
        Word = word.ToLowerInvariant();
        ParsedContent = parsedContent.ToLowerInvariant();
    }

    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode() => 
        Word.ToLowerInvariant().GetHashCode();

    public string Word { get; set; }
    public string ParsedContent { get; set; }
}