using PoemTokenization.Tokenizers;
using RhythmAnalysing.Tests.Services;

namespace RhythmAnalysing.Tests;

public class SetPreviousAccentuationTests
{
    private PoemTokenizer _poemTokenizer = null!;
    private PreviousAccentsSetter _previousAccentsSetter = null!;

    [SetUp]
    public void Setup()
    {
        _previousAccentsSetter = PreviousAccentsSetterProvider.CreateAccentsAnalyzer();
        _poemTokenizer = new();
    }

    [Test]
    [TestCase("Небо", new[]{0})]
    [TestCase("небо", new[]{0})]
    [TestCase("Земля", new[]{1})]
    [TestCase("земля", new[]{1})]
    [TestCase("Острів", new[]{0})]
    [TestCase("Аберація", new[]{2})]
    [TestCase("Кількаскладовий", new[]{3})]
    public void TestSetPreviousAccentsOfSimpleWord(string word, int[] expectedAccent)
    {
        var tokenizedPoem = _poemTokenizer.Tokenize(new(word));
        var tokenizedWords = tokenizedPoem.AllWords;
        Assert.That(tokenizedWords, Has.Count.EqualTo(1));
        var tokenizedWord = tokenizedWords[0];
        _previousAccentsSetter.SetPossibleAccentuations(tokenizedWord);
        Assert.That(tokenizedWord.PossibleAccentuations, Is.EqualTo(expectedAccent));
    }
    
    [Test]
    [TestCase("Небо земля", new[]{0, 1})]
    [TestCase("Небо і земля", new[]{0, 0, 1})]
    public void TestSetPreviousAccentsOfSentence(string sentence, int[] expectedAccent)
    {
        var tokenizedPoem = _poemTokenizer.Tokenize(new(sentence));
        var tokenizedWords = tokenizedPoem.AllWords;

        foreach (var tokenizedWord in tokenizedWords)
            _previousAccentsSetter.SetPossibleAccentuations(tokenizedWord);

        for (var i = 0; i < expectedAccent.Length; i++)
        {
            var currentWord = tokenizedWords[i];
            var expectedAccentuation = expectedAccent[i];
            
            var wordAccentuations = currentWord.PossibleAccentuations;
            var hasExpectedAccent = wordAccentuations.Contains(expectedAccentuation);
            Assert.That(hasExpectedAccent, Is.True, $"Word {{{currentWord}}} expected to have accentuation {expectedAccentuation} but hadn't.");
        }
    }
}