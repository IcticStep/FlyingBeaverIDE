using System.Data;
using System.Text.Json;
using Domain;

namespace FlyingBeaverIDE.Logic;

public class FlyingBeaver
{
    public FlyingBeaver() { }
    public FlyingBeaver(string json) => _poem = DeserializePoem(json);

    private readonly Poem _poem = new Poem();

    public string PoemText
    {
        get => _poem.Text;
        set => _poem.Text = value;
    }

    public string GetSaveDataJSON() =>
        JsonSerializer.Serialize(_poem);

    private Poem DeserializePoem(string json)
    {
        var poem = JsonSerializer.Deserialize<Poem>(json);
        if (poem is not null)
            return poem;

        throw new InvalidDataException();
    }
}