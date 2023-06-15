using Domain.Analysing.Results;

namespace FlyingBeaverIDE.UI.Services.AnalyzeResultsView;

public class RhythmResultDrawer : AnalyzeViewer
{
    public RhythmResultDrawer(RichTextBox viewer) : base(viewer)
    {
    }

    private readonly Color _successColor = Color.Chartreuse;
    private readonly Color _failColor = Color.Gold;

    public override void Draw(AnalyzeResult result)
    {
        if (result.RhythmResult is null)
            return;
        
        SaveSelection();
        
        ClearView();
        var rhythmResult = result.RhythmResult;
        var successful = rhythmResult.CorrectRhythmicPositions;
        var failed = rhythmResult.FailedRhythmicPositions;
        
        DrawByPositions(successful, _successColor);
        DrawByPositions(failed, _failColor);
        
        LoadSelection();
    }
}