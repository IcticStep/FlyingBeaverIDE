using Domain.Main.Rhythmics;

namespace Domain.Main;

[Serializable]
public class Poem : ICloneable
{
    public Poem() { }
    
    public Poem(string text) 
        => Text = text;
    
    public Poem(string text, Rhythm rhythm) : this(text) => 
        _rhythm = rhythm;

    public event Action OnEdit;
    
    private string _text = string.Empty;
    private Rhythm _rhythm;

    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            OnEdit?.Invoke();
        }
    }

    public Rhythm Rhythm
    {
        get => _rhythm;
        set
        {
            _rhythm = value;
            OnEdit?.Invoke();
        }
    }

    public override int GetHashCode() => 
        HashCode.Combine(Text.GetHashCode(), Rhythm.GetHashCode());

    public object Clone() =>
        new Poem(_text, _rhythm);
}