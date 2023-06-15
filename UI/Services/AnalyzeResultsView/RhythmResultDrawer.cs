using Domain.Analysing.Results;

namespace FlyingBeaverIDE.UI.Services.AnalyzeResultsView;

public class RhythmResultDrawer
{
    public RhythmResultDrawer(RichTextBox viewer)
    {
        _viewer = viewer;
        _standardColor = _viewer.ForeColor;
    }

    private readonly RichTextBox _viewer;
    private readonly Color _standardColor;
    private readonly Color _successColor = Color.Chartreuse;
    private readonly Color _failColor = Color.Gold;
    private int _oldSelectionStart;
    private int _oldSelectionLength;

    public void Draw(AnalyzeResult result)
    {
        _oldSelectionStart = _viewer.SelectionStart;
        _oldSelectionLength = _viewer.SelectionLength;
        
        ClearView();
        var rhythmResult = result.RhythmResult;
        var successful = rhythmResult.CorrectRhythmicPositions;
        var failed = rhythmResult.FailedRhythmicPositions;
        
        DrawByPositions(successful, _successColor);
        DrawByPositions(failed, _failColor);
        
        _viewer.SelectionStart = _oldSelectionStart;
        _viewer.SelectionLength = _oldSelectionLength;
    }

    private void DrawByPositions(IEnumerable<int> positions, Color color)
    {
        foreach (var position in positions)
        {
            _viewer.Select(position, 1);
            _viewer.SelectionColor = color;
            _viewer.DeselectAll();
        }
    }

    private void ClearView()
    {
        _viewer.Select(0, _viewer.TextLength);
        _viewer.SelectionColor = _standardColor;
        _viewer.DeselectAll();
    }
}