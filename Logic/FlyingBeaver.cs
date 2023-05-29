using Domain;

namespace FlyingBeaverIDE.Logic;

public class FlyingBeaver
{
    public FlyingBeaver() => 
        SubscribeOnPoemUpdate();

    public FlyingBeaver(Poem poem) : this()
    {
        _poem = poem;
        SubscribeOnPoemUpdate();
    }

    private readonly Poem _poem = new Poem();

    public event Action? OnUpdated;

    public Poem Poem => (Poem)_poem.Clone();

    public string PoemText
    {
        get => _poem.Text;
        set => _poem.Text = value;
    }

    private void SubscribeOnPoemUpdate() => 
        _poem.OnEdit += () => OnUpdated?.Invoke();
}