namespace Domain.Analysing.Results;

public class RhythmResult
{
    public RhythmResult(IEnumerable<int> failedRhythmicPositions, IEnumerable<int> correctRhythmicPositions)
    {
        _failedRhythmicPositions = failedRhythmicPositions.ToList();
        _correctRhythmicPositions = correctRhythmicPositions.ToList();
    }

    private readonly List<int> _failedRhythmicPositions;
    private readonly List<int> _correctRhythmicPositions;

    public IReadOnlyList<int> FailedRhythmicPositions => _failedRhythmicPositions;
    public IReadOnlyList<int> CorrectRhythmicPositions => _correctRhythmicPositions;

    public override bool Equals(object? obj)
    {
        if (obj is not RhythmResult other)
            return false;

        return FailedRhythmicPositions.SequenceEqual(other.FailedRhythmicPositions)
               && CorrectRhythmicPositions.SequenceEqual(other.CorrectRhythmicPositions);
    }
}
