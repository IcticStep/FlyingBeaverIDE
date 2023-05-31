using Domain.Tokenized;
using PoemTokenizer.Tokenizers;

namespace PoemTokenizer.Tests;

public class CalculatingWordTokens
{
    private Worder _worder = default!;

    [SetUp]
    public void SetUp() =>
        _worder = new Worder();

    [Test]
    public void CheckEmptyIfEmptyText() =>
        CheckResultIsExpected("", Enumerable.Empty<WordToken>());

    [Test]
    public void CheckEmptyIfWhiteSpaceText() =>
        CheckResultIsExpected(" ", Enumerable.Empty<WordToken>());

    [Test]
    public void CheckExceptionIfNull() =>
        Assert.Throws<ArgumentNullException>(() =>
            _worder.Tokenize(null!));

    [Test]
    [TestCase("Якесь")]
    [TestCase("Слово")]
    [TestCase("Просто")]
    [TestCase("Приклад")]
    [TestCase("Я")]
    [TestCase("Інкапсуляція")]
    public void CheckWordValuesIfWord(string input)
    {
        var wordTokens = _worder.Tokenize(input).ToArray();
        Assert.That(wordTokens, Has.Length.EqualTo(1));

        var actual = wordTokens.First().RawText.ToLower();
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
    public void CheckWordsValueIfClearSentence(string input, string[] expected) =>
        CheckWordsValuesAreExpected(input, expected);

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
    public void CheckWordsAreClearIfRealSentence(string input, string[] expected) =>
        CheckWordsValuesAreExpected(input, expected);

    [Test]
    [TestCase("Привіт")]
    [TestCase("Просто")]
    [TestCase("Слова")]
    public void CheckPositionsIfWord(string input) =>
        CheckPositionsAreExpected(input, new[] { 0 });

    [Test]
    [TestCase("Привіт тобі", new[] { 0, 7 })]
    [TestCase("Щось дивні речі кояться", new[] { 0, 6, 12, 17 })]
    [TestCase("Дивовижне речення ще одних слів", new[] { 0, 11, 19, 22, 28 })]
    public void CheckPositionsIfClearSentence(string input, int[] expected) =>
        CheckPositionsAreExpected(input, new[] { 0 });

    public void CheckWholeToken()
    {
        var syllabler = new Syllabler();
        
        var input = "Повна,, токено-перевірка.\n";
        List<WordToken> expected = new()
        {
            new("повна", syllabler.Tokenize("повна").ToList(), 0),
            new("токено", syllabler.Tokenize("токено").ToList(), 9),
            new("перевірка", syllabler.Tokenize("перевірка").ToList(), 16),
        };
        
        var wordTokens = _worder.Tokenize(input).ToList();
        Assert.That(wordTokens, Has.Count.EqualTo(expected.Count));
        Assert.That(wordTokens.AsEnumerable(), Is.EqualTo(expected.AsEnumerable()));
    }

    public void CheckPositionsAreExpected(string input, int[] expected)
    {
        var wordTokens = _worder.Tokenize(input).ToArray();
        Assert.That(wordTokens, Has.Length.EqualTo(expected));
        var resultedWordValues = wordTokens.Select(x => x.Position).ToArray();
        Assert.That(resultedWordValues, Is.EqualTo(expected));
    }

    private void CheckWordsValuesAreExpected(string input, string[] expected)
    {
        var wordTokens = _worder.Tokenize(input).ToArray();
        Assert.That(wordTokens, Has.Length.EqualTo(expected));
        var resultedWordValues = wordTokens.Select(x => x.RawText).ToArray();
        Assert.That(resultedWordValues, Is.EqualTo(expected));
    }

    private void CheckResultIsExpected(string input, IEnumerable<WordToken> expected)
    {
        var wordTokens =  _worder.Tokenize(input);
        Assert.That(wordTokens, Is.EqualTo(expected));
    }
}