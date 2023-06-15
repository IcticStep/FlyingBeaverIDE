using PoemTokenization.Tokenizers;

namespace RhymeAnalaysing.Tests;

public class RhymeTests
{
    private PoemTokenizer _poemTokenizer;
    private RhymeAnalyzer _rhymeAnalyzer;
    
    [SetUp]
    public void Setup()
    {
        _poemTokenizer = new();
        _rhymeAnalyzer = new();
    }

    [Test]
    [TestCase("Жук люк", new[]{1, 5})]
    [TestCase("Ая-яй", new[]{0,1,3})]
    public void FindSimpleRhyme(string text, IEnumerable<int> expected)
    {
        var tokenizedPoem = _poemTokenizer.Tokenize(new(text));
        var result = _rhymeAnalyzer.Analyze(tokenizedPoem).First();

        foreach (var rhymeGroup in result.RhymeGroups)
        {
            if(rhymeGroup.Count != expected.Count())
                continue;
            
            foreach (var part in expected)
            {
                if(!rhymeGroup.Contains(part))
                    continue;
                Assert.Pass();
            }
        }
        Assert.Fail();
    }
}