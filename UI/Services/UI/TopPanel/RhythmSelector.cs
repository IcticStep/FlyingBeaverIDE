using Domain.Main.Rhythmics;

namespace FlyingBeaverIDE.UI.Services.UI.TopPanel;

public class RhythmSelector
{
    private readonly List<Rhythm> _availableRhythms;
    private readonly ToolStripComboBox _viewer;

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