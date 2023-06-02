using PoemTokenization.Tokenizers;

namespace PoemTokenizer.Tests;

public class CountingSyllablesTests
{
    private SyllablesTokenizer _syllablesTokenizer = default!;
    
    [SetUp]
    public void SetUp() => 
        _syllablesTokenizer = new SyllablesTokenizer();

    [Test]
    public void TestZeroIfEmptyText() => 
        TestResultIsExpected("", 0);

    [Test]
    public void TestZeroIfWhiteSpace() => 
        TestResultIsExpected(" ", 0);

    [Test]
    public void TestExceptionIfNull() =>
        Assert.Throws<ArgumentNullException>(() => 
            _syllablesTokenizer.CountSyllables(null!));

    [Test]
    [TestCase("Я",1)]
    [TestCase("Бобер",2)]
    [TestCase("Чому",2)]
    [TestCase("Літати",3)]
    [TestCase("Князівство",3)]
    [TestCase("Інкапсуляція",6)]
    [TestCase("Непередбачувана",7)]
    [TestCase("Рентгеноелектрокардіографічного", 13)]
    public void TestVowelsCountIfOneWord(string text, int expectedVowelsCount) => 
        TestResultIsExpected(text, expectedVowelsCount);
    
    [Test]
    [TestCase("Бувають дні...",4)]
    [TestCase("Бувають ночі...",5)]
    [TestCase("Чорний день і чорна хмара",8)]
    [TestCase("Реве та стогне Дніпр широкий",9)]
    [TestCase("Бачу давній сон, в ньому давня ти",10)]
    [TestCase("Завтра прийде до кімнати твоїх друзів небагато",16)]
    public void TestVowelsCountIfText(string text, int expectedVowelsCount) => 
        TestResultIsExpected(text, expectedVowelsCount);

    private void TestResultIsExpected(string input, int expected)
    {
        var countSyllables =  _syllablesTokenizer.CountSyllables(input);
        Assert.That(countSyllables, Is.EqualTo(expected));
    }
}