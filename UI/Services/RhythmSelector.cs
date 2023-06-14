using Domain.Main.Rhythmics;

namespace FlyingBeaverIDE.UI.Services;

public class RhythmSelector
{
    private Rhythm[] _availableRhythms;
    private ToolStripComboBox _viewer;

    public Action<Rhythm> OnUpdated;

    public RhythmSelector(Rhythm[] availableRhythms, ToolStripComboBox viewer)
    {
        _availableRhythms = availableRhythms;
        _viewer = viewer;
        
        _viewer.Items.Clear();
        _viewer.Items.AddRange(_availableRhythms.ToArray());
        _viewer.SelectedIndexChanged += HandleIndexChanged;
    }

    private void HandleIndexChanged(object? sender, EventArgs eventArgs) => 
        OnUpdated?.Invoke((Rhythm)_viewer.SelectedItem);
}