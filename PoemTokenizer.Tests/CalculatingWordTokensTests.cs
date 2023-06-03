using Domain.Tokens;
using Domain.Tokens.Api;
using PoemTokenization.Tokenizers;

namespace PoemTokenizer.Tests;

public class CalculatingWordTokensTests
{
    private WordsTokenizer _wordsTokenizer = default!;

    [SetUp]
    public void SetUp() =>
        _wordsTokenizer = new WordsTokenizer();

    [Test]
    public void TestEmptyIfEmptyText() =>
        CheckResultIsExpected("", Enumerable.Empty<WordToken>());

    [Test]
    public void TestEmptyIfWhiteSpaceText() =>
        CheckResultIsExpected(" ", Enumerable.Empty<WordToken>());

    [Test]
    public void TestExceptionIfNull() =>
        Assert.Throws<ArgumentNullException>(() =>
            _wordsTokenizer.Tokenize(null!));

    [Test]
    [TestCase("Якесь")]
    [TestCase("Слово")]
    [TestCase("Просто")]
    [TestCase("Приклад")]
    [TestCase("Я")]
    [TestCase("Інкапсуляція")]
    public void TestWordValuesIfWord(string input)
    {
        var wordTokens = _wordsTokenizer.Tokenize(input).ToArray();
        Assert.That(wordTokens, Has.Length.EqualTo(1));

        string actual = wordTokens.First().RawText.ToLower();
        Assert.That(actual, Is.EqualTo(input.ToLower()));
    }

    [Test]
    [TestCase(
        "Просто слова через пробіл",
        new[] { "просто", "слова", "через", "пробіл" })]
    [TestCase(
        "Ще якісь слова",
        new[] { "ще", "якісь", "слова" })]
    [TestCase(
        "Остання перевірка тому багато слів без розділових знаків",
        new[] { "остання", "перевірка", "тому", "багато", "слів", "без", "розділових", "знаків" })]
    public void TestWordsValueIfClearSentence(string input, string[] expected) =>
        TestWordsValuesAreExpected(input, expected);

    [Test]
    [TestCase(
        "Привіт, світ!",
        new[] { "привіт", "світ" })]
    [TestCase(
        "Чорний день і чорна хмара, на папері чорна пляма\n",
        new[] { "чорний", "день", "і", "чорна", "хмара", "на", "папері", "чорна", "пляма" })]
    [TestCase(
        "Очевидно, що знаки пунктуації треба усунути.\nПовністю.\n\n",
        new[] { "очевидно", "що", "знаки", "пунктуації", "треба", "усунути", "повністю" })]
    [TestCase(
        "Слова-слова дефісні. Окремо мають бути.",
        new[] { "слова", "слова", "дефісні", "окремо", "мають", "бути"})]
    public void TestWordsAreClearIfRealSentence(string input, string[] expected) =>
        TestWordsValuesAreExpected(input, expected);

    [Test]
    [TestCase("Привіт")]
    [TestCase("Просто")]
    [TestCase("Слова")]
    public void TestPositionsIfWord(string input) =>
        TestPositionsAreExpected(input, new[] { 0 });

    [Test]
    [TestCase("Привіт тобі", new[] { 0, 7 })]
    [TestCase("Щось дивні речі кояться", new[] { 0, 5, 11, 16 })]
    [TestCase("Дивовижне речення ще одних слів", new[] { 0, 10, 18, 21, 27 })]
    public void TestPositionsIfClearSentence(string input, int[] expected) =>
        TestPositionsAreExpected(input, expected);

    [Test]
    public void TestWholeToken()
    {
        var syllabler = new SyllablesTokenizer();
        
        var input = "Повна,, токено-перевірка.\n";
        List<WordToken> expected = new()
        {
            new("повна", syllabler.Tokenize("повна").ToList(), 0),
            new("токено", syllabler.Tokenize("токено").ToList(), 8),
            new("перевірка", syllabler.Tokenize("перевірка").ToList(), 15),
        };
        
        var wordTokens = _wordsTokenizer.Tokenize(input).ToList();
        Assert.That(wordTokens, Has.Count.EqualTo(expected.Count));
        Assert.That(wordTokens, Is.EqualTo(expected));
    }


    private void TestPositionsAreExpected(string input, int[] expected)
    {
        var wordTokens = _wordsTokenizer.Tokenize(input).ToArray();
        Assert.That(wordTokens, Has.Length.EqualTo(expected.Length));
        var resultedWordValues = wordTokens.Select(x => x.Position).ToArray();
        Assert.That(resultedWordValues, Is.EqualTo(expected));
    }

    private void TestWordsValuesAreExpected(string input, string[] expected)
    {
        var wordTokens = _wordsTokenizer.Tokenize(input).ToArray();
        Assert.That(wordTokens, Has.Length.EqualTo(expected.Length));
        var resultedWordValues = wordTokens.Select(x => x.RawText).ToArray();
        Assert.That(resultedWordValues, Is.EqualTo(expected));
    }

    private void CheckResultIsExpected(string input, IEnumerable<IWordToken> expected)
    {
        var wordTokens =  _wordsTokenizer.Tokenize( input);
        Assert.That(wordTokens, Is.EqualTo(expected));
    }
}