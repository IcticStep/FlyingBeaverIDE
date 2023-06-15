using DataStorage.Accentuations.Api;

namespace FlyingBeaverIDE.UI.Services.UI;

public class LocalDictionaryEditorViewer
{
    private IAccentuationsRepository _accentuationsRepository;

    public Action Edited;
    
    public LocalDictionaryEditorViewer(IAccentuationsRepository accentuationsAccentuationsDictionary) => 
        _accentuationsRepository = accentuationsAccentuationsDictionary;

    public void Show(IEnumerable<string> unknownWords)
    {
        var editor = new LocalDictionaryForm(_accentuationsRepository, unknownWords);
        editor.ShowDialog();
        Edited?.Invoke();
    }
}