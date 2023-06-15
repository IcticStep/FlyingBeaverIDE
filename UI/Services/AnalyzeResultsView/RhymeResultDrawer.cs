using Domain.Analysing.Results;

namespace FlyingBeaverIDE.UI.Services.AnalyzeResultsView;

public class RhymeResultDrawer : AnalyzeViewer
{
    public RhymeResultDrawer(RichTextBox viewer) : base(viewer)
    {
    }

    private readonly Color[] _groupColors = new[]
    {
        Color.Beige,
        Color.Brown,
        Color.Aqua,
        Color.Orange,
        Color.Chartreuse,
        Color.Fuchsia, 
    };

    public override void Draw(AnalyzeResult result)
    {
        if (result.RhymeVerseResults is null)
            return;
        
        SaveSelection();
        foreach (var verse in result.RhymeVerseResults)
            for (var i = 0; i < verse.RhymeGroups.Count; i++)
                DrawByPositions(verse.RhymeGroups[i], _groupColors[i]);
        LoadSelection();
    }
}