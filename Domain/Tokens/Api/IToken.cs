namespace Domain.Tokens.Api;

public interface IToken
{
    public int Position { get; }
    public int AbsolutePosition { get; }
    public void AdjustAbsolutePosition(int value);
}