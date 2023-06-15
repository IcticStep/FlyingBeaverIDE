using System.Collections;
using System.Text;
using Domain.Analysing.Tokens.Api.Concrete;

namespace Domain.Analysing.Results;

public class RhythmResult
{
    public RhythmResult(IEnumerable<IWordToken> unknownWords)
    {
        _unknownWords = unknownWords.ToList();
        Failed = true;
    }
    
    public RhythmResult(IEnumerable<int> failedRhythmicPositions, IEnumerable<int> correctRhythmicPositions)
    {
        _failedRhythmicPositions = failedRhythmicPositions.ToList();
        _correctRhythmicPositions = correctRhythmicPositions.ToList();
    }

    private readonly List<int> _failedRhythmicPositions = new();
    private readonly List<int> _correctRhythmicPositions = new();
    private readonly List<IWordToken> _unknownWords = new();

    public readonly bool Failed;
    public IReadOnlyList<int> FailedRhythmicPositions => _failedRhythmicPositions;
    public IReadOnlyList<int> CorrectRhythmicPositions => _correctRhythmicPositions;

    public IReadOnlyList<IWordToken> UnknownWords => _unknownWords;

    public override bool Equals(object? obj)
    {
        if (obj is not RhythmResult other)
            return false;

        return FailedRhythmicPositions.SequenceEqual(other.FailedRhythmicPositions)
               && CorrectRhythmicPositions.SequenceEqual(other.CorrectRhythmicPositions);
    }

    public override string ToString() => 
        $"Правильно: {{{GetStringOfCollection(CorrectRhythmicPositions)}}} " +
        $"Неправильно: {{{GetStringOfCollection(FailedRhythmicPositions)}}}" +
        $"Невідомі слова {{{GetStringOfCollection(UnknownWords, WordToString)}}}";

    private string GetStringOfCollection(IEnumerable collection, Func<object?, string> converter = null)
    {
        if (collection is null)
            return string.Empty;

        var builder = new StringBuilder();
        foreach (var element in collection)
        {
            var stringedElement = converter is null ? element : converter.Invoke(element);
            builder.Append(stringedElement);
            builder.Append(' ');
        }

        if(builder.Length > 0)
            builder.Remove(builder.Length - 1, 1);

        return builder.ToString();
    }

    private string WordToString(object? wordObject) => 
        wordObject is not IWordToken wordToken 
            ? string.Empty
            : wordToken.RawText;
}
