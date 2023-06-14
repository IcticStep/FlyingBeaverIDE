using Domain.Analysing.Results;
using FlyingBeaverIDE.UI.Services.UI.TopPanel;

namespace FlyingBeaverIDE.UI.Services.AnalyzeResultsView;

public class AnalyzeResultsViewer
{
    private readonly LocalDictionaryPreviewer _localDictionaryPreviewer;
    private RhythmResult _rhythmResult;
    private List<string> _unknownWords = new();

    public AnalyzeResultsViewer(LocalDictionaryPreviewer localDictionaryPreviewer) => 
        _localDictionaryPreviewer = localDictionaryPreviewer;

    public IReadOnlyList<string> UnknownWords => _unknownWords;

    public void ShowResults(AnalyzeResult analyzeResult)
    {
        _rhythmResult = analyzeResult.RhythmResult;
        CacheUnknownWords(analyzeResult);
        ShowUnknownWordsCount();
        Console.WriteLine($"Result: {{{analyzeResult.RhythmResult}}}");
    }

    private void CacheUnknownWords(AnalyzeResult analyzeResult) => 
        _unknownWords = analyzeResult.RhythmResult.UnknownWords
            .Select(token => token.RawText)
            .ToList();

    private void ShowUnknownWordsCount() => 
        _localDictionaryPreviewer.SetUnknownWordsCount(_rhythmResult.UnknownWords.Count);
}