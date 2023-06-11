using Microsoft.Extensions.Configuration;
using PoemTokenization.Tokenizers;

namespace RhythmAnalyzer.Tests;

public class SetAccentuationTests
{
    private const string UserNameConfigKey = "UserName";
    private const string UserPasswordConfigKey = "UserPassword";
    private const string ConnectionStringConfigKey = "ConnectionString";
    
    private AccentsAnalyzer _accentsAnalyzer = null!;
    private PoemTokenizer _poemTokenizer = null!;
    
    [SetUp]
    public void Setup()
    {
        _accentsAnalyzer = CreateAccentsAnalyzer();
        _poemTokenizer = new();
    }

    [Test]
    [TestCase("Небо", new[]{1})]
    [TestCase("небо", new[]{1})]
    [TestCase("Земля", new[]{2})]
    [TestCase("земля", new[]{2})]
    [TestCase("Острів", new[]{1})]
    [TestCase("Аберація", new[]{3})]
    [TestCase("Кількаскладовий", new[]{4})]
    public void SetAccentOfSimpleWord(string word, int[] expectedAccent)
    {
        var tokenizedPoem = _poemTokenizer.Tokenize(new(word));
        var tokenizedWords = tokenizedPoem.AllWords;
        Assert.That(tokenizedWords, Has.Count.EqualTo(1));
        var tokenizedWord = tokenizedWords[0];
        _accentsAnalyzer.SetPossibleAccentuations(tokenizedWord);
        Assert.That(tokenizedWord.PossibleAccentuations, Is.EqualTo(expectedAccent));
    }

    private static AccentsAnalyzer CreateAccentsAnalyzer()
    {
        var configuration = BuildAppConfig();
        return InitAccentsAnalyzer(configuration);
    }
    
    private static IConfigurationRoot BuildAppConfig() =>
        new ConfigurationBuilder()
            .AddUserSecrets<SetAccentuationTests>()
            .Build();

    private static AccentsAnalyzer InitAccentsAnalyzer(IConfiguration configuration) =>
        new (new(
            configuration[ConnectionStringConfigKey]!,
            configuration[UserNameConfigKey]!,
            configuration[UserPasswordConfigKey]!));
}