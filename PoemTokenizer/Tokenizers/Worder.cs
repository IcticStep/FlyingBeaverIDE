using Domain.Tokenized;
using PoemTokenizer.Data;

namespace PoemTokenizer.Tokenizers;

public class Worder
{
    // Привіт, мене звати так.
    public IEnumerable<WordToken> Tokenize(string text)
    {
        throw new NotImplementedException();
    }

    private IEnumerable<RawWordToken> SplitInRawWords(string text)
    {
        throw new NotImplementedException();
        // List<RawWordToken> result = new();
        // var lastSpacePosition = -1;
        //
        // for (var i = 0; i < text.Length; i++)
        // {
        //     if (text[i] == ' ')
        //     {
        //         
        //     }
        // }
    }
}