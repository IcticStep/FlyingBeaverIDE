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
    public void TestTrocheeAccentuatedCorrect(int syllableIndex, bool expectedAccentuated) => 
        TestGivenRhythmsAccentuatedSyllablesIndex(
            RhythmBank.TrocheeGroup, 
            syllableIndex, 
            expectedAccentuated);

    [Test]
    [TestCase(0, false)]
    [TestCase(1, true)]
    [TestCase(2, false)]
    [TestCase(3, true)]
    public void TestIambAccentuatedCorrect(int syllableIndex, bool expectedAccentuated) =>
        TestGivenRhythmsAccentuatedSyllablesIndex(
            RhythmBank.IambGroup, 
            syllableIndex, 
            expectedAccentuated);
        
    [Test]
    [TestCase(0, true)]
    [TestCase(1, false)]
    [TestCase(2, false)]
    [TestCase(3, true)]
    [TestCase(4, false)]
    [TestCase(5, false)]
    [TestCase(6, true)]
    public void TestDactylAccentuatedCorrect(int syllableIndex, bool expectedAccentuated) =>
        TestGivenRhythmsAccentuatedSyllablesIndex(
            RhythmBank.DactylGroup, 
            syllableIndex, 
            expectedAccentuated);
    
    [Test]
    [TestCase(0, false)]
    [TestCase(1, true)]
    [TestCase(2, false)]
    [TestCase(3, false)]
    [TestCase(4, true)]
    [TestCase(5, false)]
    [TestCase(6, false)]
    public void TestAmphibrachAccentuatedCorrect(int syllableIndex, bool expectedAccentuated) =>
        TestGivenRhythmsAccentuatedSyllablesIndex(
            RhythmBank.AmphibrachGroup, 
            syllableIndex, 
            expectedAccentuated);
    
    [Test]
    [TestCase(0, false)]
    [TestCase(1, false)]
    [TestCase(2, true)]
    [TestCase(3, false)]
    [TestCase(4, false)]
    [TestCase(5, true)]
    [TestCase(6, false)]
    public void TestAnapestAccentuatedCorrect(int syllableIndex, bool expectedAccentuated) =>
        TestGivenRhythmsAccentuatedSyllablesIndex(
            RhythmBank.AnapestGroup, 
            syllableIndex, 
            expectedAccentuated);

    [Test]
    [TestCase(new[]{true, false})]
    [TestCase(new[]{true, false, true})]
    [TestCase(new[]{true, false, true, false, true, false})]
    public void TestGeneratedSchemeTrochee(bool[] expected) =>
        TestGivenRhythmGeneratedSchemes(RhythmBank.TrocheeGroup, expected.Length, expected);

    [Test]
    [TestCase(new[]{false, true})]
    [TestCase(new[]{false, true, false})]
    [TestCase(new[]{false, true, false, true, false, true})]
    public void TestGeneratedSchemeIamb(bool[] expected)  =>
        TestGivenRhythmGeneratedSchemes(RhythmBank.IambGroup, expected.Length, expected);
    
    [Test]
    [TestCase(new[]{true, false})]
    [TestCase(new[]{true, false, false})]
    [TestCase(new[]{true, false, false, true, false, false})]
    [TestCase(new[]{true, false, false, true, false, false, true, false})]
    public void TestGeneratedSchemeDactyl(bool[] expected)  =>
        TestGivenRhythmGeneratedSchemes(RhythmBank.DactylGroup, expected.Length, expected);
    
    [Test]
    [TestCase(new[]{false, true})]
    [TestCase(new[]{false, true, false})]
    [TestCase(new[]{false, true, false, false, true, false})]
    [TestCase(new[]{false, true, false, false, true, false, false, true})]
    public void TestGeneratedSchemeAmphibrach(bool[] expected)  =>
        TestGivenRhythmGeneratedSchemes(RhythmBank.AmphibrachGroup, expected.Length, expected);
    
    [Test]
    [TestCase(new[]{false, false})]
    [TestCase(new[]{false, false, true})]
    [TestCase(new[]{false, false, true, false, false, true})]
    [TestCase(new[]{false, false, true, false, false, true, false, false})]
    public void TestGeneratedSchemeAnapest(bool[] expected)  =>
        TestGivenRhythmGeneratedSchemes(RhythmBank.AnapestGroup, expected.Length, expected);
    
    private void TestGivenRhythmGeneratedSchemes(IEnumerable<Rhythm> rhythms, int length, bool[] expected)
    {
        foreach (var rhythm in rhythms)
            TestRhythmGeneratedScheme(rhythm, length, expected);
    }

    private void TestGivenRhythmsAccentuatedSyllablesIndex(IEnumerable<Rhythm> testingRhythms, int syllableIndex,
        bool expectedAccentuated)
    {
        foreach (var testingRhythm in testingRhythms)
            TestRhythmAccentuatedSyllablesIndex(testingRhythm, syllableIndex, expectedAccentuated);
    }

    private void TestRhythmGeneratedScheme(Rhythm rhythm, int length, bool[] expected)
    {
        var actual = rhythm.GenerateAccentuationScheme(length);
        Assert.That(actual, Is.EqualTo(expected));
    }

    private void TestRhythmAccentuatedSyllablesIndex(Rhythm rhythm, int syllableIndex, bool expectedAccentuated)
    {
        var actual = rhythm.SyllableShouldBeAccentuated(syllableIndex);
        Assert.That(actual, Is.EqualTo(expectedAccentuated));
    }
}