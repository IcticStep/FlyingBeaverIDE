using DataStorage;
using Domain.Analysing.Results;
using Domain.Analysing.Tokens.Concrete;

namespace RhythmAnalysing;

public class RhythmAnalyzer
{
    public RhythmAnalyzer(DataBaseCredentials dataBaseCredentials)
    {
        _previousAccentsSetter = new(dataBaseCredentials);
        _rhythmAccentsSetter = new();
    }

    private readonly PreviousAccentsSetter _previousAccentsSetter;
    private readonly RhythmAccentsSetter _rhythmAccentsSetter;

    public RhythmResult Analyze(PoemToken poem)
    {
        SetPreviousAccentuations(poem);

        throw new NotImplementedException();
    }

    private void SetPreviousAccentuations(PoemToken poem)
    {
        var words = poem.AllWords;
        foreach (var word in words)
            _previousAccentsSetter.SetPossibleAccentuations(word);
    }
}