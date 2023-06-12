using Domain.Analysing.Results;
using Domain.Analysing.Tokens.Api.Concrete;
using Domain.Analysing.Tokens.Concrete;

namespace RhythmAnalysing.Services;

public class CorrectRhythmChecker
{
    private readonly List<int> _failedRhythmicPositions = new();
    private readonly List<int> _correctRhythmicPositions = new();
    
    public RhythmResult Analyze(PoemToken poemToken)
    {
        _failedRhythmicPositions.Clear();
        _correctRhythmicPositions.Clear();

        foreach (var verse in poemToken.Verses)
            AnalyzeVerse(poemToken, verse);

        return new(_failedRhythmicPositions, _correctRhythmicPositions);
    }

    private void AnalyzeVerse(PoemToken poemToken, IVerseToken verse)
    {
        var syllables = verse.AllSyllables;
        var expectedScheme = poemToken.Rhythm.GenerateAccentuationScheme(syllables.Count);

        AnalyzeCorrectionOfScheme(expectedScheme, syllables);
    }

    private void AnalyzeCorrectionOfScheme(IReadOnlyList<bool> expectedScheme, IReadOnlyList<ISyllableToken> syllables)
    {
        for (var i = 0; i < expectedScheme.Count; i++)
        {
            var currentSyllable = syllables[i];
            var currentPosition = currentSyllable.AbsolutePosition;

            if (currentSyllable.IsAccentuated != expectedScheme[i])
            {
                _failedRhythmicPositions.Add(currentPosition);
                break;
            }

            _correctRhythmicPositions.Add(currentPosition);
        }
    }
}