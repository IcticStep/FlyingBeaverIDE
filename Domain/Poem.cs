﻿namespace Domain;

[Serializable]
public class Poem : ICloneable
{
    public Poem() { }
    
    public Poem(string text) 
        => Text = text;
    
    private Poem(string text, Rhythm rhythm) : this(text) => 
        _rhythm = rhythm;

    public event Action OnEdit;
    
    private string _text = string.Empty;
    private Rhythm _rhythm = new();

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

    public object Clone() => new Poem(_text, _rhythm);
}