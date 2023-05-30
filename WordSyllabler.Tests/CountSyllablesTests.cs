namespace WordSyllabler.Tests;

public class CountSyllablesTests
{
    private Syllabler _syllabler = default!;
    
    [SetUp]
    public void SetUp() => 
        _syllabler = new Syllabler();

    [Test]
    public void CheckZeroIfEmptyText() => 
        TestResultIsExpected("", 0);

    [Test]
    public void CheckZeroIfWhiteSpace() => 
        TestResultIsExpected(" ", 0);

    [Test]
    public void CheckExceptionIfNull() =>
        Assert.Throws<ArgumentNullException>(() => 
            _syllabler.CountSyllables(null!));

    [Test]
    [TestCase("Я",1)]
    [TestCase("Бобер",2)]
    [TestCase("Чому",2)]
    [TestCase("Літати",3)]
    [TestCase("Князівство",3)]
    [TestCase("Інкапсуляція",6)]
    [TestCase("Непередбачувана",7)]
    [TestCase("Рентгеноелектрокардіографічного", 13)]
    public void CheckVowelsCountIfOneWord(string text, int expectedVowelsCount) => 
        TestResultIsExpected(text, expectedVowelsCount);
    
    [Test]
    [TestCase("Бувають дні...",4)]
    [TestCase("Бувають ночі...",5)]
    [TestCase("Чорний день і чорна хмара",8)]
    [TestCase("Реве та стогне Дніпр широкий",9)]
    [TestCase("Бачу давній сон, в ньому давня ти",10)]
    [TestCase("Завтра прийде до кімнати твоїх друзів небагато",16)]
    public void CheckVowelsCountIfText(string text, int expectedVowelsCount) => 
        TestResultIsExpected(text, expectedVowelsCount);

    private void TestResultIsExpected(string input, int expected)
    {
        var countSyllables =  _syllabler.CountSyllables(input);
        Assert.That(countSyllables, Is.EqualTo(expected));
    }
}