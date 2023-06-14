namespace FlyingBeaverIDE.UI.Services.UI.TopPanel;

public class LocalDictionaryPreviewer
{
    public LocalDictionaryPreviewer(ToolStripLabel viewer) => 
        _viewer = viewer;

    private const string StatusPrefix = "Незнайомі слова: ";
    //private readonly Color _normalStateColor = Color.LightGray;
    //private readonly Color _incorrectStateColor = Color.Red;
    private readonly ToolStripLabel _viewer;
    
    public void SetUnknownWordsCount(int count)
    {
        _viewer.Text = StatusPrefix + count;
        //_viewer.ForeColor = count > 0 ? _incorrectStateColor : _normalStateColor;
    }
}