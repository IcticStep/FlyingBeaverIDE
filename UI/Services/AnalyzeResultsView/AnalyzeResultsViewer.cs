using Domain.Analysing.Results;
using FlyingBeaverIDE.UI.Services.UI.TopPanel;

namespace FlyingBeaverIDE.UI.Services.AnalyzeResultsView;

public class AnalyzeResultsViewer
{
    private readonly LocalDictionaryPreviewer _localDictionaryPreviewer;
    private readonly AnalyzeViewer[] _analyzeViewers;
    private RhythmResult? _rhythmResult;
    private List<string> _unknownWords = new();

    public AnalyzeResultsViewer(LocalDictionaryPreviewer localDictionaryPreviewer, RichTextBox poemViewer)
    {
        _localDictionaryPreviewer = localDictionaryPreviewer;
        _analyzeViewers = new AnalyzeViewer[] 
        { 
            new RhythmResultDrawer(poemViewer),
            new RhymeResultDrawer(poemViewer) 
        };
    }

    public IReadOnlyList<string> UnknownWords => _unknownWords;

    public void ShowResults(AnalyzeResult analyzeResult)
    {
        _rhythmResult = analyzeResult.RhythmResult;
        CacheUnknownWords(analyzeResult);
        ShowUnknownWordsCount();
        DrawResults(analyzeResult);
    }

    private void DrawResults(AnalyzeResult result)
    {
        foreach (var viewer in _analyzeViewers)
            viewer.Draw(result);
    }

    private void CacheUnknownWords(AnalyzeResult analyzeResult)
    {
        if(analyzeResult.RhythmResult is null)
            return;
        
        _unknownWords = analyzeResult.RhythmResult.UnknownWords
            .Select(token => token.RawText)
            .ToList();
    }

    private void ShowUnknownWordsCount()
    {
        if(_rhythmResult is null)
            return;
        
        _localDictionaryPreviewer.SetUnknownWordsCount(_rhythmResult.UnknownWords.Count);
    }
}