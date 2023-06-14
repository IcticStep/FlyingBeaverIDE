namespace Domain.Analysing.Results;

public class AnalyzeResult
{
    public AnalyzeResult(RhythmResult? rhythmResult) => 
        RhythmResult = rhythmResult;

    public RhythmResult? RhythmResult { get; }

    public override string ToString() => 
        RhythmResult?.ToString();
}