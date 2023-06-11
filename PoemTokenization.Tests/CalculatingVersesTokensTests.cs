using Domain.Analysing.Tokens.Api.Concrete;
using PoemTokenization.Tokenizers;

namespace PoemTokenization.Tests;

public class CalculatingVersesTokensTests
{
    private VersesTokenizer _versesTokenizer = default!;

    [SetUp]
    public void SetUp() => 
        _versesTokenizer = new VersesTokenizer();
    
    [Test]
    public void TestEmptyIfEmptyText() => 
        TestResultIsExpected("", Enumerable.Empty<IVerseToken>());

    [Test]
    public void TestEmptyIfWhiteSpaceText() => 
        TestResultIsExpected(" ", Enumerable.Empty<IVerseToken>());

    [Test]
    public void TestExceptionIfNull() => 
        Assert.Throws<ArgumentNullException>(() => 
            _versesTokenizer.Tokenize((string)null!));

    [TestCase("А\n\nБ",
        new[]{"А","Б"},
        new[]{0,3})]
    [TestCase("А\n\nБ\nВ",
        new[]{"А","Б\nВ"},
        new[]{0,3})]
    [TestCase("Останні дні такі дурні...\nЯ їх не звав - прийшли чому?\nІдуть вони до дна пусті:\nІ їм все гра - мені лиш гул.\n\n" +
              "Останні сни такі значні,\nАж наче той, хто їх писав,\nВгадав усі мої слабкі\nТа підло-гучно постріляв.\n\n" +
              "Останні пси уже пішли\nМолити кращого життя...\nМені ж тюрми зостались дні\nІ зовсім не моя війна.",
        new[]
        {
            "Останні дні такі дурні...\nЯ їх не звав - прийшли чому?\nІдуть вони до дна пусті:\nІ їм все гра - мені лиш гул.",
            "Останні сни такі значні,\nАж наче той, хто їх писав,\nВгадав усі мої слабкі\nТа підло-гучно постріляв.",
            "Останні пси уже пішли\nМолити кращого життя...\nМені ж тюрми зостались дні\nІ зовсім не моя війна."
        },
        new[]{0, 110, 211})]
    [Test]
    public void TestSplittingRealPoem(string input, string[] expectedVerses, int[] expectedPositions)
    {
        var actual = _versesTokenizer
            .Tokenize(input)
            .ToArray();
        var actualVersesTexts = actual
            .Select(token => token.RawVerse)
            .ToArray();
        var actualPositions = actual
            .Select(token => token.Position)
            .ToArray();
        
        Assert.That(actual, Has.Length.EqualTo(expectedVerses.Length));
        Assert.That(actual, Has.Length.EqualTo(expectedPositions.Length));
        Assert.That(actualVersesTexts, Is.EqualTo(expectedVerses));
        Assert.That(actualPositions, Is.EqualTo(expectedPositions));
    }
    
    [Test]
    [TestCase("Аба.", new[]{"а", "а"}, new[]{0, 2})]
    [TestCase("Привіт тобі.", new[]{"и", "і", "о", "і"}, new[]{2, 4, 8, 10})]
    [TestCase("Навіщо? Чому?", new[]{"а", "і", "о", "о", "у"}, new[]{1, 3, 5, 9, 11})]
    [TestCase("Якісь цікаві речі", new[]{"я", "і", "і", "а", "і", "е", "і"}, new[]{0, 2, 7, 9, 11, 14, 16})]
    public void TestSyllablesAbsolutePositions(string input, string[] expectedValues, int[] expectedPositions)
    {
        var wordTokens = _versesTokenizer.Tokenize(input).ToArray();
        var allSyllables = wordTokens.SelectMany(token => token.AllSyllables).ToArray();
        Assert.That(allSyllables, Has.Length.EqualTo(expectedValues.Length));
        Assert.That(allSyllables, Has.Length.EqualTo(expectedPositions.Length));
        
        var actualValues = allSyllables.Select(syllable => syllable.Vowel);
        var actualPositions = allSyllables.Select(syllable => syllable.AbsolutePosition);
        Assert.That(expectedValues, Is.EqualTo(actualValues));
        Assert.That(expectedPositions, Is.EqualTo(actualPositions));
    }
    
    private void TestResultIsExpected(string input, IEnumerable<IVerseToken> expected)
    {
        var countSyllables =  _versesTokenizer.Tokenize(input);
        Assert.That(countSyllables, Is.EqualTo(expected));
    }
}