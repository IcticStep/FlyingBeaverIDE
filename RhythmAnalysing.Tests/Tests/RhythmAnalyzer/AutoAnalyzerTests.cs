using Domain.Analysing.Results;
using Domain.Analysing.Tokens.Concrete;
using Domain.Main;
using Domain.Main.Rhythmics;
using PoemTokenization.Tokenizers;
using RhythmAnalysing.Analyzers;
using RhythmAnalysing.Tests.Services;

namespace RhythmAnalysing.Tests.Tests.RhythmAnalyzer;

public class AutoAnalyzerTests
{
    private PoemTokenizer _poemTokenizer = null!;
    private RhythmAnalysing.RhythmAnalyzer _analyzer = null!;
    
    [SetUp]
    public void Setup()
    {
        _poemTokenizer = new();
        var schemeAnalyzer = new SchemeAutoAnalyzer(DatabaseCredentialsProvider.DatabaseCredentials);
        _analyzer = new RhythmAnalysing.RhythmAnalyzer(schemeAnalyzer);
    }

    [Test]
    [TestCase("Впали дні всі", new int[0], new[]{2, 4, 8, 12})]
    public void TestTrochee(string rawPoem, IEnumerable<int> expectedFails, IEnumerable<int> expectedCorrect) => 
        TestAllRhythmSchemes(rawPoem, RhythmBank.TrocheeGroup, expectedFails, expectedCorrect);

    private void TestAllRhythmSchemes(string rawPoem, Rhythm[] rhythms, 
        IEnumerable<int> expectedFails, IEnumerable<int> expectedCorrect)
    {
        var expectedResult = new RhythmResult(expectedFails, expectedCorrect);
        var poems = rhythms
            .Select(rhythm => new Poem(rawPoem, rhythm))
            .ToList();

        var tokenizedPoems = poems
            .Select(poem => _poemTokenizer.Tokenize(poem))
            .ToList();

        foreach (var poem in tokenizedPoems)
            TestScheme(poem, expectedResult);
    }

    private void TestScheme(PoemToken poem, RhythmResult expected)
    {
        var actual = _analyzer.Analyze(poem);
        Assert.That(actual, Is.EqualTo(expected));
    }
}