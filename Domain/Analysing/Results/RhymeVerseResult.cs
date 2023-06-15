namespace Domain.Analysing.Results;

public class RhymeVerseResult
{
    public RhymeVerseResult(IReadOnlyList<IReadOnlyList<int>> rhymeGroups) => 
        RhymeGroups = rhymeGroups;

    public IReadOnlyList<IReadOnlyList<int>> RhymeGroups { get; }
}