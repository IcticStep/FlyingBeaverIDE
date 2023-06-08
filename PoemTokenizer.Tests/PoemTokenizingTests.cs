using Domain;
using Domain.Tokens.Api;
using PoemTokenization.Tokenizers;

namespace PoemTokenizer.Tests;

public class PoemTokenizingTests
{
    private PoemTokenization.Tokenizers.PoemTokenizer _poemTokenizer = default!;
    
    [SetUp]
    public void SetUp() => 
        _poemTokenizer = new();

    [Test]
    public void TestEmptyIfEmptyText() => 
        TestResultIsExpected("", Enumerable.Empty<ISyllableToken>());

    [Test]
    public void TestEmptyIfWhiteSpaceText() => 
        TestResultIsExpected(" ", Enumerable.Empty<ISyllableToken>());
    
    [Test]
    [TestCase("я", new[]{0})]
    [TestCase("і", new[]{0})]
    [TestCase("чому", new[]{1,3})]
    [TestCase("небо", new[]{1,3})]
    [TestCase("знаєш", new[]{2,3})]
    [TestCase("бачиш", new[]{1,3})]
    [TestCase("оскільки", new[]{0,3,7})]
    [TestCase("інкапсуляція", new[]{0,3,6,8,10,11})]
    public void TestPositionsIfWord(string input, IEnumerable<int> expectedPositions) => 
        TestResultIsExpected(input, expectedPositions);
    
    [Test]
    [TestCase("Знаєш, як болить...", new[]{2,3,7,11,13})]
    [TestCase("Ніяк не пройде.", new[]{1,2,6,10,13})]
    public void TestPositionsIfSentence(string input, IEnumerable<int> expectedPositions) => 
        TestResultIsExpected(input, expectedPositions);
    
    [Test]
    [TestCase("А\n\nБА", new[]{0,4})]
    [TestCase("Слово\n\nЩе трохи\n\nКінець", new[]{2, 4, 8, 12, 14, 18, 20})]
    public void TestPositionsIfVerses(string input, IEnumerable<int> expectedPositions) => 
        TestResultIsExpected(input, expectedPositions);

    private void TestResultIsExpected(string input, IEnumerable<ISyllableToken> expected)
    {
        var poem = new Poem(input);
        var tokenizedPoem =  _poemTokenizer.Tokenize(poem);
        var tokenizedSyllables = tokenizedPoem.AllSyllables;
        Assert.That(tokenizedSyllables, Is.EqualTo(expected));
    }
    
    private void TestResultIsExpected(string input, IEnumerable<int> expectedPositions)
    {
        var poem = new Poem(input);
        var tokenizedPoem =  _poemTokenizer.Tokenize(poem);
        var tokenizedSyllables = tokenizedPoem.AllSyllables;
        var actualPositions = tokenizedSyllables.Select(syllable => syllable.Position);
        Assert.That(actualPositions, Is.EqualTo(expectedPositions));
    }
}