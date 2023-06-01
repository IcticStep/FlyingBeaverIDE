using Domain.Tokenized;
using PoemTokenizer.Tokenizers;

namespace PoemTokenizer.Tests;

public class CalculatingVersesTokensTests
{
    private VersesTokenizer _versesTokenizer = default!;

    [SetUp]
    public void SetUp() => 
        _versesTokenizer = new VersesTokenizer();
    
    [Test]
    public void CheckEmptyIfEmptyText() => 
        TestResultIsExpected("", Enumerable.Empty<VerseToken>());

    [Test]
    public void CheckEmptyIfWhiteSpaceText() => 
        TestResultIsExpected(" ", Enumerable.Empty<VerseToken>());

    [Test]
    public void CheckExceptionIfNull() => 
        Assert.Throws<ArgumentNullException>(() => 
            _versesTokenizer.Tokenize(null!));

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
    public void CheckSplittingRealPoem(string input, string[] expectedVerses, int[] expectedPositions)
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
    
    private void TestResultIsExpected(string input, IEnumerable<VerseToken> expected)
    {
        var countSyllables =  _versesTokenizer.Tokenize(input);
        Assert.That(countSyllables, Is.EqualTo(expected));
    }
}