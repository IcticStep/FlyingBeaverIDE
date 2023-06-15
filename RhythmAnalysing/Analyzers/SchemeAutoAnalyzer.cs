using System.Collections;
using DataStorage;
using DataStorage.Accentuations.Api;
using Domain.Analysing.Results;
using Domain.Analysing.Tokens.Api.Concrete;
using Domain.Analysing.Tokens.Concrete;
using MongoDB.Bson.Serialization.Serializers;
using RhythmAnalysing.Api;
using RhythmAnalysing.Services;

namespace RhythmAnalysing.Analyzers;

public class SchemeAutoAnalyzer : BasicSchemeAnalyzer
{
    public SchemeAutoAnalyzer(IReadOnlyAccentuationsRepository accentuationsRepository) 
        : base(accentuationsRepository)
    {
        
    }

    private readonly RhythmAccentsSetter _rhythmAccentsSetter = new();
    private readonly CorrectRhythmChecker _correctRhythmChecker = new();
    
    protected override RhythmResult FinishAnalyzing(PoemToken poem)
    {
        var failedWords = GetFailedWords(poem);
        if (failedWords.Any())
            return new RhythmResult(failedWords);
        
        SetAccentuations(poem);
        return _correctRhythmChecker.Analyze(poem);
    }

    private IEnumerable<IWordToken> GetFailedWords(PoemToken poemToken) =>
        poemToken.AllWords
            .Where(word => !word.PossibleAccentuations.Any())
            .Where(word => word.SyllableTokens.Count > 1);

    private void SetAccentuations(PoemToken poem)
    {
        foreach (var verse in poem.Verses)
            _rhythmAccentsSetter.SetAccentsByPrevious(verse, poem.Rhythm);
    }
}