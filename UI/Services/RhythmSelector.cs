using Domain.Main.Rhythmics;

namespace FlyingBeaverIDE.UI.Services;

public class RhythmSelector
{
    private List<Rhythm> _availableRhythms;
    private ToolStripComboBox _viewer;

    public Action<Rhythm> OnUpdated;

    public RhythmSelector(IEnumerable<Rhythm> availableRhythms, ToolStripComboBox viewer)
    {
        _availableRhythms = availableRhythms.ToList();
        _viewer = viewer;
        
        _viewer.Items.Clear();
        _viewer.Items.AddRange(_availableRhythms.ToArray());
        _viewer.SelectedItem = 0;
        _viewer.SelectedIndexChanged += HandleIndexChanged;
    }

    private void HandleIndexChanged(object? sender, EventArgs eventArgs) => 
        OnUpdated?.Invoke((Rhythm)_viewer.SelectedItem);

    public void Set(Rhythm rhythm)
    {
        var index = _availableRhythms
            .FindIndex(data => data.Equals(rhythm));

        _viewer.SelectedIndex = index;
    }
}