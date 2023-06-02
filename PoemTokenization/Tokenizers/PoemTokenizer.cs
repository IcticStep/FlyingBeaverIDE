using Domain;
using Domain.Tokens;

namespace PoemTokenization.Tokenizers;

public class PoemTokenizer
{
    private readonly VersesTokenizer _versesTokenizer = new();

    public PoemToken Tokenize(Poem poem) =>
        new(poem,
            _versesTokenizer
                .Tokenize(poem)
                .ToList());
}