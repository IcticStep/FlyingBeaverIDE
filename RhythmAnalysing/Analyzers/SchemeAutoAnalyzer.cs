using DataStorage;
using Domain.Analysing.Results;
using Domain.Analysing.Tokens.Concrete;
using RhythmAnalysing.Api;
using RhythmAnalysing.Services;

namespace RhythmAnalysing.Analyzers;

public class SchemeAutoAnalyzer : BasicSchemeAnalyzer
{
    public SchemeAutoAnalyzer(DataBaseCredentials dataBaseCredentials) 
        : base(dataBaseCredentials)
    {
        
    }

    private readonly RhythmAccentsSetter _rhythmAccentsSetter = new();
    private readonly CorrectRhythmChecker _correctRhythmChecker = new();
    
    protected override RhythmResult FinishAnalyzing(PoemToken poem)
    {
        SetAccentuations(poem);
        return _correctRhythmChecker.Analyze(poem);
    }

    private void SetAccentuations(PoemToken poem)
    {
        foreach (var verse in poem.Verses)
            _rhythmAccentsSetter.SetAccentsByPrevious(verse, poem.Rhythm);
    }
}