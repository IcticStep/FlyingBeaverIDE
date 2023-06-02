﻿using Domain.Tokens;
using PoemTokenization.Tokenizers;

namespace PoemTokenizer.Tests;

public class CalculatingSyllableTokensTests
{
    private SyllablesTokenizer _syllablesTokenizer = default!;
    
    [SetUp]
    public void SetUp() => 
        _syllablesTokenizer = new SyllablesTokenizer();

    [Test]
    public void TestEmptyIfEmptyText() => 
        TestResultIsExpected("", Enumerable.Empty<SyllableToken>());

    [Test]
    public void TestEmptyIfWhiteSpaceText() => 
        TestResultIsExpected(" ", Enumerable.Empty<SyllableToken>());

    [Test]
    public void TestExceptionIfNull() => 
        Assert.Throws<ArgumentNullException>(() => 
            _syllablesTokenizer.CountSyllables(null!));

    [TestCase("й")]
    [TestCase("з")]
    [TestCase("в")]
    [TestCase("пфф")]
    [TestCase("првт")]
    [TestCase("впрнксмт")]
    [Test]
    public void TestNoTokensIfNoVowels(string input) =>
        TestResultIsExpected(input, Enumerable.Empty<SyllableToken>());

    [TestCase("я", new[]{0})]
    [TestCase("і", new[]{0})]
    [TestCase("чому", new[]{1,3})]
    [TestCase("небо", new[]{1,3})]
    [TestCase("знаєш", new[]{2,3})]
    [TestCase("бачиш", new[]{1,3})]
    [TestCase("оскільки", new[]{0,3,7})]
    [TestCase("інкапсуляція", new[]{0,3,6,8,10,11})]
    [Test]
    public void TestTokensIfOneWord(string input, IEnumerable<int> expectedVowels) => 
        TestResultIsExpectedByVowelsPosition(input, expectedVowels);

    [TestCase("Знаєш, як болить...", new[]{2,3,7,11,13})]
    [TestCase("Ніяк не пройде.", new[]{1,2,6,10,13})]
    [Test]
    public void TestPositionsIfText(string input, IEnumerable<int> expected) =>
        TestResultIsExpectedByVowelsPosition(input, expected);

    private void TestResultIsExpectedByVowelsPosition(string input, IEnumerable<int> expectedVowels)
    {
        var expected = expectedVowels
            .Select(index =>
                new SyllableToken(
                    input[index].ToString(),
                    index));

        TestResultIsExpected(input, expected);
    }

    private void TestResultIsExpected(string input, IEnumerable<SyllableToken> expected)
    {
        var countSyllables =  _syllablesTokenizer.Tokenize(input);
        Assert.That(countSyllables, Is.EqualTo(expected));
    }
}