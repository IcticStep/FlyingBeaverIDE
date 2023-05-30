namespace WordSyllabler;

public class Syllabler
{
    private const string Vowels = "аоуиіеяюєї";
    
    public int CountSyllables(string text)
    {
        if (text is null)
            throw new ArgumentNullException();
        
        var lower = text.ToLowerInvariant();
        return lower.Count(IsVowel);
    }

    public IEnumerable<int> GetVowelsPositions(string text) =>
        text.ToLowerInvariant()
            .Select((symbol, index) => (symbol, index))
            .Where((token, index) => IsVowel(token.symbol))
            .Select(token => token.index);

    public IEnumerable<SyllableToken> GetSyllableTokens(string text)
    {
        var vowelsPositions = GetVowelsPositions(text);
        return vowelsPositions.Select(position => 
            new SyllableToken(text[position].ToString(), position));
    }

    private bool IsVowel(char symbol) => 
        Vowels.Contains(symbol, StringComparison.InvariantCultureIgnoreCase);
}