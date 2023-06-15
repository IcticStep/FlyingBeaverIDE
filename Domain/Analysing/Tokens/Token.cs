using Domain.Analysing.Tokens.Api;

namespace Domain.Analysing.Tokens;

public abstract class Token : IToken
{
    protected Token(int position, int absolutePosition)
    {
        Position = position;
        AbsolutePosition = absolutePosition;
    }

    public int Position { get; }
    public int AbsolutePosition { get; private set; }
}