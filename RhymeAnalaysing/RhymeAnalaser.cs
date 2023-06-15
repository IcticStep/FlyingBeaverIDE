using Domain.Analysing.Results;
using Domain.Analysing.Tokens.Api.Concrete;
using Domain.Analysing.Tokens.Concrete;

namespace RhymeAnalaysing;

public class RhymeAnalyzer
{
    private readonly string[][] _rhymeGroups = new[]
    {
        new[] { "а", "я" },
        new[] { "ю", "у" },
        new[] { "о" },
        new[] { "и", "і", "ї" },
        new[] { "е", "є" }
    };
    
    public IEnumerable<RhymeVerseResult> Analyze(PoemToken poemToken) => 
        poemToken.Verses.Select(verse => AnalyzeVerse(verse));
    
    public async Task<IEnumerable<RhymeVerseResult>> AnalyzeAsync(PoemToken poem) =>
        await Task.Run(() => Analyze(poem));

    private RhymeVerseResult AnalyzeVerse(IVerseToken verse)
    {
        var groups = new List<List<int>>();
        foreach (var rhymeGroup in _rhymeGroups)
        {
            var rhymeGroupRepresentatives = verse.AllSyllables
                .Where(syllable => rhymeGroup.Contains(syllable.Vowel))
                .Select(syllable => syllable.AbsolutePosition)
                .ToList();
            if(rhymeGroupRepresentatives.Count > 1)
                groups.Add(rhymeGroupRepresentatives);
        }

        return new(groups);
    }
}