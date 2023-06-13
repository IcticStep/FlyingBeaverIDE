using System.Collections;
using System.Text;

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

    public override string ToString() => 
        $"Правильно: {{{GetStringOfCollection(CorrectRhythmicPositions)}}} " +
        $"Неправильно: {{{GetStringOfCollection(FailedRhythmicPositions)}}}";

    private string GetStringOfCollection(IEnumerable collection)
    {
        var builder = new StringBuilder();
        foreach (var element in collection)
        {
            builder.Append(element);
            builder.Append(' ');
        }

        if(builder.Length > 0)
            builder.Remove(builder.Length - 1, 1);

        return builder.ToString();
    }
}
