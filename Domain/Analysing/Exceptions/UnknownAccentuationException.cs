using Domain.Analysing.Tokens.Api.Concrete;

namespace Domain.Analysing.Exceptions;

public class UnknownAccentuationException : Exception
{
    public UnknownAccentuationException(string word) => 
        Word = word;

    public UnknownAccentuationException(IWordToken word)
        : this(word.RawText)
    {
        
    }
    
    public string Word { get; private set; }

    public override string ToString() => Word;
}