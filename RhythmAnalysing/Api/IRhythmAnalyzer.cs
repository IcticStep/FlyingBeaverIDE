using Domain.Analysing.Results;
using Domain.Analysing.Tokens.Concrete;

namespace RhythmAnalysing.Api;

public interface IRhythmAnalyzer
{
    public RhythmResult Analyze(PoemToken poem);
}