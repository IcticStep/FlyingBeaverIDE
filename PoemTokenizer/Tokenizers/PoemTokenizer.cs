using Domain;
using Domain.Tokenized;

namespace PoemTokenizer.Tokenizers;

public class PoemTokenizer
{
    private readonly VersesTokenizer _versesTokenizer = new();

    public PoemToken Tokenize(Poem poem) =>
        new(poem,
            _versesTokenizer
                .Tokenize(poem)
                .ToList());
}