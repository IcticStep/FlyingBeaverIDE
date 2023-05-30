namespace HtmlParserSlovnyk.Domain;

public class WordParsedContentComparer : IComparer<WordParsedContent>, IEqualityComparer<WordParsedContent>
{
    public int Compare(WordParsedContent? x, WordParsedContent? y) => 
        string.Compare(x?.Word, y?.Word, StringComparison.OrdinalIgnoreCase);

    public bool Equals(WordParsedContent? x, WordParsedContent? y) => 
        Compare(x, y) == 0;

    public int GetHashCode(WordParsedContent obj) => 
        obj.GetHashCode();
}