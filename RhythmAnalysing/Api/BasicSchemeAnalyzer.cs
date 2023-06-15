using DataStorage;
using DataStorage.Accentuations.Api;
using Domain.Analysing.Results;
using Domain.Analysing.Tokens.Concrete;
using RhythmAnalysing.Services;

namespace RhythmAnalysing.Api;

public abstract class BasicSchemeAnalyzer : IRhythmAnalyzer
{
    protected BasicSchemeAnalyzer(IReadOnlyAccentuationsRepository accentuationsRepository) => 
        _previousAccentsSetter = new(accentuationsRepository);

    private readonly PreviousAccentsSetter _previousAccentsSetter;

    public RhythmResult Analyze(PoemToken poem)
    {
        SetPreviousAccentuations(poem);
        return FinishAnalyzing(poem);
    }

    protected abstract RhythmResult FinishAnalyzing(PoemToken poem);

    private void SetPreviousAccentuations(PoemToken poem)
    {
        foreach (var word in poem.AllWords)
            _previousAccentsSetter.SetPossibleAccentuations(word);
    }
}