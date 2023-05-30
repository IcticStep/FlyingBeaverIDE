namespace WordSyllabler.Tests;

public class FindSyllablesTests
{
    private Syllabler _syllabler = default!;
    
    [SetUp]
    public void SetUp() => 
        _syllabler = new Syllabler();

    [Test]
    public void CheckEmptyIfEmptyText() => 
        TestResultIsExpected("", Enumerable.Empty<int>());

    [Test]
    public void CheckEmptyIfWhiteSpaceText() => 
        TestResultIsExpected(" ", Enumerable.Empty<int>());

    [Test]
    public void CheckExceptionIfNull() => 
        Assert.Throws<ArgumentNullException>(() => 
            _syllabler.CountSyllables(null!));

    [TestCase("й")]
    [TestCase("з")]
    [TestCase("в")]
    [TestCase("пфф")]
    [TestCase("првт")]
    [TestCase("впрнксмт")]
    [Test]
    public void CheckNoPositionsIfNoVowels(string input) =>
        TestResultIsExpected(input, Enumerable.Empty<int>());

    [TestCase("я", new[]{0})]
    [TestCase("і", new[]{0})]
    [TestCase("чому", new[]{1,3})]
    [TestCase("небо", new[]{1,3})]
    [TestCase("знаєш", new[]{2,3})]
    [TestCase("бачиш", new[]{1,3})]
    [TestCase("оскільки", new[]{0,3,7})]
    [TestCase("інкапсуляція", new[]{0,3,6,8,10,11})]
    [Test]
    public void CheckPositionsIfOneWord(string input, IEnumerable<int> expected) =>
        TestResultIsExpected(input, expected);

    [TestCase("Знаєш, як болить...", new[]{2,3,7,11,13})]
    [TestCase("Ніяк не пройде.", new[]{1,2,6,10,13})]
    [Test]
    public void CheckPositionsIfText(string input, IEnumerable<int> expected) =>
        TestResultIsExpected(input, expected);
    
    private void TestResultIsExpected(string input, IEnumerable<int> expected)
    {
        var countSyllables =  _syllabler.GetVowelsPositions(input);
        Assert.That(countSyllables, Is.EqualTo(expected));
    }
}