namespace Domain;

[Serializable]
public class Poem
{
    private string _text = String.Empty;
    private Rythm _rythm = new();

    public event Action<Poem> OnEdit;

    public Poem() { }
    public Poem(string text) => Text = text;

    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            OnEdit?.Invoke(this);
        }
    }

    public Rythm Rythm
    {
        get => _rythm;
        set
        {
            _rythm = value;
            OnEdit?.Invoke(this);
        }
    }
}