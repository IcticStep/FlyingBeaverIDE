using Domain;
using Domain.Tokens.Api;
using Domain.Tokens.Api.Concrete;
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
        TestResultIsExpectedVowelsTokens("", Enumerable.Empty<ISyllableToken>());

    [Test]
    public void TestEmptyIfWhiteSpaceText() => 
        TestResultIsExpectedVowelsTokens(" ", Enumerable.Empty<ISyllableToken>());
    
    [Test]
    [TestCase("я", new[]{0})]
    [TestCase("і", new[]{0})]
    [TestCase("чому", new[]{1,3})]
    [TestCase("небо", new[]{1,3})]
    [TestCase("знаєш", new[]{2,3})]
    [TestCase("бачиш", new[]{1,3})]
    [TestCase("оскільки", new[]{0,3,7})]
    [TestCase("інкапсуляція", new[]{0,3,6,8,10,11})]
    public void TestVowelsPositionsIfWord(string input, IEnumerable<int> expectedPositions) => 
        TestResultIsExpectedVowelsPositions(input, expectedPositions);
    
    [Test]
    [TestCase("Знаєш, як болить...", new[]{2,3,7,11,13})]
    [TestCase("Ніяк не пройде.", new[]{1,2,6,10,13})]
    public void TestVowelsPositionsIfSentence(string input, IEnumerable<int> expectedPositions) => 
        TestResultIsExpectedVowelsPositions(input, expectedPositions);
    
    [Test]
    [TestCase("А\n\nБА", new[]{0,4})]
    [TestCase("Слово\n\nЩе трохи\n\nКінець", new[]{2, 4, 8, 12, 14, 18, 20})]
    public void TestVowelsPositionsIfVerses(string input, IEnumerable<int> expectedPositions) => 
        TestResultIsExpectedVowelsPositions(input, expectedPositions);
    
    [Test]
    [TestCase("Слово")]
    [TestCase("Тест")]
    public void TestWordsPositionsIfWords(string input) => 
        TestResultIsExpectedWordsPositions(input, new[]{0});
    
    [Test]
    [TestCase("Декілька слів написано.", new[]{0, 9, 14})]
    [TestCase("Земля-земля, я їсти хочу.", new[]{0, 6, 13, 15, 20})]
    [TestCase("Слово - не горобець, на шашлик не пустиш.", new[]{0, 8, 11, 21, 24, 31, 34})]
    public void TestWordsPositionsIfSentence(string input, IEnumerable<int> expectedPositions) => 
        TestResultIsExpectedWordsPositions(input, expectedPositions);
    
    [Test]
    [TestCase("Декілька слів\n\nнаписано.", new[]{0, 9, 15})]
    [TestCase("Земля-земля\n\nя їсти хочу.", new[]{0, 6, 13, 15, 20})]
    [TestCase("Слово - не горобець, на шашлик не пустиш.\n\nВсе інше - можна.", new[]{0, 8, 11, 21, 24, 31, 34, 43, 47, 54})]
    public void TestWordsPositionsIfVerses(string input, IEnumerable<int> expectedPositions) => 
        TestResultIsExpectedWordsPositions(input, expectedPositions);

    private void TestResultIsExpectedVowelsTokens(string input, IEnumerable<ISyllableToken> expected)
    {
        var poem = new Poem(input);
        var tokenizedPoem =  _poemTokenizer.Tokenize(poem);
        var tokenizedSyllables = tokenizedPoem.AllSyllables;
        Assert.That(tokenizedSyllables, Is.EqualTo(expected));
    }
    
    private void TestResultIsExpectedVowelsPositions(string input, IEnumerable<int> expectedPositions)
    {
        var poem = new Poem(input);
        var tokenizedPoem =  _poemTokenizer.Tokenize(poem);
        var tokenizedSyllables = tokenizedPoem.AllSyllables;
        var actualPositions = tokenizedSyllables.Select(syllable => syllable.AbsolutePosition);
        Assert.That(actualPositions, Is.EqualTo(expectedPositions));
    }
    
    private void TestResultIsExpectedWordsPositions(string input, IEnumerable<int> expectedPositions)
    {
        var poem = new Poem(input);
        var tokenizedPoem =  _poemTokenizer.Tokenize(poem);
        var tokenizedWords = tokenizedPoem.AllWords;
        var actualPositions = tokenizedWords.Select(word => word.AbsolutePosition);
        Assert.That(actualPositions, Is.EqualTo(expectedPositions));
    }
}