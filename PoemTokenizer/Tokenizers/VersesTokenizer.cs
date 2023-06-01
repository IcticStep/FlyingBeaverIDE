using Domain.Tokenized;
using PoemTokenizer.Data;

namespace PoemTokenizer.Tokenizers;

public class VersesTokenizer
{
    public IEnumerable<VerseToken> Tokenize(string input) => 
        throw new NotImplementedException();

    private IReadOnlyList<RawToken> GetRowTokens(string text, string request) => 
        throw new NotImplementedException();
}