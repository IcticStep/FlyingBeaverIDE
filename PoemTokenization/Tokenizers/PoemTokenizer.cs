using Domain.Analysing.Tokens.Concrete;
using Domain.Main;

namespace PoemTokenization.Tokenizers;

public class PoemTokenizer
{
    private readonly VersesTokenizer _versesTokenizer = new();

    public PoemToken Tokenize(Poem poem) =>
        new(poem,
            _versesTokenizer
                .Tokenize(poem)
                .ToList());

    public async Task<PoemToken> TokenizeAsync(Poem poem) => 
        await Task.Run(() => Tokenize(poem));
}