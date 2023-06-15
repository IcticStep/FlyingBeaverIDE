using Domain.Main.Rhythmics;
using FlyingBeaverIDE.Logic;

namespace FlyingBeaverIDE.UI.Services.UI.TopPanel;

public class AnalyzerSelector
{
    private readonly ToolStripComboBox _viewer;
    private Dictionary<Analyzer, string> _headers = new();
    private readonly List<Analyzer> _analyzers = new(){ Analyzer.None, Analyzer.Rhythm, Analyzer.Rhyme };

    public Action<Analyzer> OnUpdated;

    public AnalyzerSelector(ToolStripComboBox viewer)
    {
        _viewer = viewer;
        InitHeaders();

        _viewer.Items.AddRange(GetNames().ToArray());
        _viewer.SelectedIndexChanged += HandleIndexChanged;
        _viewer.SelectedItem = 0;
    }

    public void SetAnalyzer(Analyzer analyzer)
    {
        _viewer.SelectedIndex = _analyzers.FindIndex(x => x == analyzer);
        OnUpdated?.Invoke(analyzer);
    }

    private void InitHeaders()
    {
        _headers.Add(Analyzer.None, "Ніякий");
        _headers.Add(Analyzer.Rhythm, "Ритміка");
        _headers.Add(Analyzer.Rhyme, "Рима");
    }

    private IEnumerable<string> GetNames() => 
        _analyzers.Select(x => _headers[x]);

    private void HandleIndexChanged(object? sender, EventArgs eventArgs) => 
        OnUpdated?.Invoke(_analyzers[_viewer.SelectedIndex]);
}