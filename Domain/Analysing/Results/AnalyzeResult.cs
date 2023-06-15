namespace Domain.Analysing.Results;

public class AnalyzeResult
{
    public AnalyzeResult(RhythmResult? rhythmResult) => 
        RhythmResult = rhythmResult;

    public AnalyzeResult(IEnumerable<RhymeVerseResult>? rhymeVerseResults) =>
        RhymeVerseResults = rhymeVerseResults.ToList();

    public RhythmResult? RhythmResult { get; }
    public IReadOnlyList<RhymeVerseResult>? RhymeVerseResults;

    public override string ToString() => 
        RhythmResult?.ToString() + RhythmResult?.ToString();
}