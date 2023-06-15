using System.Collections;
using Domain.Analysing.Tokens.Concrete;
using Domain.Main;
using Domain.Main.Rhythmics;
using PoemTokenization.Tokenizers;
using RhythmAnalysing.Services;
using RhythmAnalysing.Tests.Services;

namespace RhythmAnalysing.Tests.Tests.Components;

public class SetAccentuationTests
{
    private PoemTokenizer _poemTokenizer = null!;
    private PreviousAccentsSetter _previousAccentsSetter = null!;
    private RhythmAccentsSetter _rhythmAccentsSetter = null!;

    [SetUp]
    public void Setup()
    {
        _previousAccentsSetter = PreviousAccentsSetterProvider.CreateAccentsAnalyzer();
        _poemTokenizer = new();
        _rhythmAccentsSetter = new();
    }

    [Test]
    [TestCase("Замок впав собі.", new[]{0, 0, 1})]
    public void TestRealAccentuationsInTrochee6(string text, int[] expectedAccentuations)
        => TestRealAccentuations(text, RhythmBank.Trochee6, expectedAccentuations);
    
    [Test]
    [TestCase("Замок закрили міцно.", new[]{1, 1, 0})]
    public void TestRealAccentuationsInIamb(string text, int[] expectedAccentuations)
        => TestRealAccentuations(text, RhythmBank.Iamb6, expectedAccentuations);

    private void TestRealAccentuations(string text, Rhythm rhythm, IEnumerable expectedAccentuations)
    {
        var poemTokenized = _poemTokenizer.Tokenize(new Poem(text, rhythm));
        SetPreviousAccents(poemTokenized);
        SetAccents(rhythm, poemTokenized);

        var actualAccentuations = poemTokenized.AllWords.Select(word => word.Accentuation);
        Assert.That(actualAccentuations, Is.EqualTo(expectedAccentuations));
    }

    private void SetAccents(Rhythm rhythm, PoemToken poemTokenized)
    {
        foreach (var verse in poemTokenized.Verses)
            _rhythmAccentsSetter.SetAccentsByPrevious(verse, rhythm);
    }

    private void SetPreviousAccents(PoemToken poemTokenized)
    {
        foreach (var word in poemTokenized.AllWords)
            _previousAccentsSetter.SetPossibleAccentuations(word);
    }
}