using Domain.Tokens.Api;

namespace Domain.Tokens;

public abstract class Token : IToken
{
    protected Token(int position, int absolutePosition)
    {
        Position = position;
        AbsolutePosition = absolutePosition;
    }

    public int Position { get; }
    public int AbsolutePosition { get; private set; }
    
    public void AdjustAbsolutePosition(int value)
    {
        if(value < 0)
            throw new ArgumentOutOfRangeException($"{nameof(value)} shoud not be less then zero.");
        AbsolutePosition += value;
        AdjustChildrenAbsolutePosition(value);
    }

    protected virtual void AdjustChildrenAbsolutePosition(int value)
    {
        
    }
}