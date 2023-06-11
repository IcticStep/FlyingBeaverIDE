using Domain.Analysing.Tokens.Concrete;
using Domain.Main.Rhythmics;

namespace RhythmAnalysing;

internal class RhythmAccentsSetter
{
    private int _currentSyllableIndex = 0;
    
    public void SetAccentsByPrevious(VerseToken verse, Rhythm rhythm)
    {
        _currentSyllableIndex = 0;
        
    }
}