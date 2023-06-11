using Domain.Main.Rhythmics;

namespace Domain.Tests;

public class RhythmTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(0, true)]
    [TestCase(1, false)]
    [TestCase(2, true)]
    [TestCase(3, false)]
    public void TestTrocheeAccentuatedCorrect(int syllableIndex, bool expectedAccentuated)
    {
        var testingRhythms = new[]
        {
            RhythmBank.Trochee2, 
            RhythmBank.Trochee4, 
            RhythmBank.Trochee6, 
            RhythmBank.Trochee8
        };

        TestGivenRhythmsAccentuatedSyllablesIndex(testingRhythms, syllableIndex, expectedAccentuated);
    }
    
    [Test]
    [TestCase(0, false)]
    [TestCase(1, true)]
    [TestCase(2, false)]
    [TestCase(3, true)]
    public void TestIambAccentuatedCorrect(int syllableIndex, bool expectedAccentuated)
    {
        var testingRhythms = new[]
        {
            RhythmBank.Iamb2, 
            RhythmBank.Iamb4, 
            RhythmBank.Iamb6,
            RhythmBank.Iamb8
        };

        TestGivenRhythmsAccentuatedSyllablesIndex(testingRhythms, syllableIndex, expectedAccentuated);
    }
    
    [Test]
    [TestCase(0, true)]
    [TestCase(1, false)]
    [TestCase(2, false)]
    [TestCase(3, true)]
    [TestCase(4, false)]
    [TestCase(5, false)]
    [TestCase(6, true)]
    public void TestDactylAccentuatedCorrect(int syllableIndex, bool expectedAccentuated)
    {
        var testingRhythms = new[]
        {
            RhythmBank.Dactyl3, 
            RhythmBank.Dactyl6, 
            RhythmBank.Dactyl9,
        };

        TestGivenRhythmsAccentuatedSyllablesIndex(testingRhythms, syllableIndex, expectedAccentuated);
    }
    
    [Test]
    [TestCase(0, false)]
    [TestCase(1, true)]
    [TestCase(2, false)]
    [TestCase(3, false)]
    [TestCase(4, true)]
    [TestCase(5, false)]
    [TestCase(6, false)]
    public void TestAmphibrachAccentuatedCorrect(int syllableIndex, bool expectedAccentuated)
    {
        var testingRhythms = new[]
        {
            RhythmBank.Amphibrach3, 
            RhythmBank.Amphibrach6, 
            RhythmBank.Amphibrach9,
        };

        TestGivenRhythmsAccentuatedSyllablesIndex(testingRhythms, syllableIndex, expectedAccentuated);
    }
    
    [Test]
    [TestCase(0, false)]
    [TestCase(1, false)]
    [TestCase(2, true)]
    [TestCase(3, false)]
    [TestCase(4, false)]
    [TestCase(5, true)]
    [TestCase(6, false)]
    public void TestAnapestAccentuatedCorrect(int syllableIndex, bool expectedAccentuated)
    {
        var testingRhythms = new[]
        {
            RhythmBank.Anapest3, 
            RhythmBank.Anapest6, 
            RhythmBank.Anapest9,
        };

        TestGivenRhythmsAccentuatedSyllablesIndex(testingRhythms, syllableIndex, expectedAccentuated);
    }

    private void TestGivenRhythmsAccentuatedSyllablesIndex(Rhythm[] testingRhythms, int syllableIndex,
        bool expectedAccentuated)
    {
        foreach (var testingRhythm in testingRhythms)
        {
            TestRhythmAccentuatedSyllablesIndex(testingRhythm, syllableIndex, expectedAccentuated);
        }
    }

    private void TestRhythmAccentuatedSyllablesIndex(Rhythm rhythm, int syllableIndex, bool expectedAccentuated)
    {
        var actual = rhythm.SyllableShouldBeAccentuated(syllableIndex);
        Assert.That(actual, Is.EqualTo(expectedAccentuated));
    }
}