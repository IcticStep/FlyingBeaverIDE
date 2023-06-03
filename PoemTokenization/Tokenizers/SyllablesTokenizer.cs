using Domain.Tokens;
using Domain.Tokens.Api;

namespace PoemTokenization.Tokenizers;

public class SyllablesTokenizer
{
    private const string Vowels = "аоуиіеяюєї";
    
    public int CountSyllables(string text)
    {
        ArgumentNullException.ThrowIfNull(text);
        
        var lower = text.ToLowerInvariant();
        return lower.Count(IsVowel);
    }

    public IEnumerable<int> GetVowelsPositions(string text) =>
        text.ToLowerInvariant()
            .Select((symbol, index) => (symbol, index))
            .Where((token, index) => IsVowel(token.symbol))
            .Select(token => token.index);

    public IEnumerable<ISyllableToken> Tokenize(string text)
    {
        var vowelsPositions = GetVowelsPositions(text);
        return vowelsPositions.Select(position => 
            new SyllableToken(text[position].ToString(), position));
    }

    private bool IsVowel(char symbol) => 
        Vowels.Contains(symbol, StringComparison.InvariantCultureIgnoreCase);
}