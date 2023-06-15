using Domain.Analysing.Results;

namespace FlyingBeaverIDE.UI.Services.AnalyzeResultsView;

public abstract class AnalyzeViewer
{
    protected AnalyzeViewer(RichTextBox viewer)
    {
        _viewer = viewer;
        _standardColor = _viewer.ForeColor;
    }

    private readonly RichTextBox _viewer;
    private readonly Color _standardColor;

    private int _oldSelectionStart;
    private int _oldSelectionLength;

    public abstract void Draw(AnalyzeResult result);

    public void ClearView()
    {
        _viewer.Select(0, _viewer.TextLength);
        _viewer.SelectionColor = _standardColor;
        _viewer.DeselectAll();
    }

    protected void SaveSelection()
    {
        _oldSelectionStart = _viewer.SelectionStart;
        _oldSelectionLength = _viewer.SelectionLength;
    }

    protected void LoadSelection()
    {
        _viewer.SelectionStart = _oldSelectionStart;
        _viewer.SelectionLength = _oldSelectionLength;
    }

    protected void DrawByPositions(IEnumerable<int> positions, Color color)
    {
        foreach (var position in positions)
        {
            _viewer.Select(position, 1);
            _viewer.SelectionColor = color;
            _viewer.DeselectAll();
        }
    }
}