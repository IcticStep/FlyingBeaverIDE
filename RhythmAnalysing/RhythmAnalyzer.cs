using Domain.Analysing.Results;
using Domain.Analysing.Tokens.Concrete;
using RhythmAnalysing.Api;

namespace RhythmAnalysing;

public sealed class RhythmAnalyzer
{
    public RhythmAnalyzer(IRhythmAnalyzer analyzer) => 
        _analyzer = analyzer;

    private IRhythmAnalyzer _analyzer;

    public RhythmResult Analyze(PoemToken poem) =>
        _analyzer.Analyze(poem);

    public async Task<RhythmResult> AnalyzeAsync(PoemToken poem) =>
        await Task.Run(() => Analyze(poem));

    public void SwitchAnalyzer(IRhythmAnalyzer newAnalyzer) =>
        _analyzer = newAnalyzer;
}