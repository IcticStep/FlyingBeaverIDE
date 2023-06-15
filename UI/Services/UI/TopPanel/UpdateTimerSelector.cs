using Domain.Main.Rhythmics;
using FlyingBeaverIDE.Logic;

namespace FlyingBeaverIDE.UI.Services.UI.TopPanel;

public class UpdateTimerSelector
{
    private readonly ToolStripComboBox _viewer;
    private readonly List<int> _timerIntervals = new() { 300, 500, 1000, 1500, 2000, 3000, 4000, 5000, 10000 };

    public Action<int> OnUpdated;

    public UpdateTimerSelector(ToolStripComboBox viewer)
    {
        _viewer = viewer;

        _viewer.Items.AddRange(_timerIntervals.Select(x => x.ToString()).ToArray());
        _viewer.SelectedIndexChanged += HandleIndexChanged;
        _viewer.SelectedItem = 0;
    }

    public void SetUpdateTimer(int interval)
    {
        if (!_timerIntervals.Contains(interval))
            throw new ArgumentOutOfRangeException(nameof(interval));
        
        _viewer.SelectedIndex = _timerIntervals.FindIndex(x => x == interval);
        OnUpdated?.Invoke(interval);
    }

    private void HandleIndexChanged(object? sender, EventArgs eventArgs) => 
        OnUpdated?.Invoke(_timerIntervals[_viewer.SelectedIndex]);
}