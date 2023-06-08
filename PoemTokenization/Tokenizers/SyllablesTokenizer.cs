using Domain.Tokens;
using Domain.Tokens.Api;
using Domain.Tokens.Api.Concrete;
using Domain.Tokens.Concrete;

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

    public IEnumerable<ISyllableToken> Tokenize(string text, int absolutePositionAdjustment = 0)
    {
        var vowelsPositions = GetVowelsPositions(text);
        return vowelsPositions.Select(position => 
            new SyllableToken(
                text[position].ToString(), 
                position,
                position+absolutePositionAdjustment));
    }

    private bool IsVowel(char symbol) => 
        Vowels.Contains(symbol, StringComparison.InvariantCultureIgnoreCase);
}