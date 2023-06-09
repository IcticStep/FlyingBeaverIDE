﻿using Domain.Analysing.Exceptions;
using Domain.Analysing.Tokens.Api.Concrete;
using Domain.Main.Rhythmics;

namespace RhythmAnalysing.Services;

public class RhythmAccentsSetter
{
    private int _currentSyllableIndex = 0;
    private Rhythm _rhythm = null!;
    
    /// <summary>
    /// Sets final accentuations in words. Should be only called after setting previous accentuations. 
    /// </summary>
    /// <param name="verse"></param>
    /// <param name="rhythm"></param>
    public void SetAccentsByPrevious(IVerseToken verse, Rhythm rhythm)
    {
        _currentSyllableIndex = 0;
        _rhythm = rhythm;     
        
        foreach (var word in verse.Words)
        {
            if(word.SyllableTokens.Count <= 1)
                continue;
            
            var shouldBeAccentuated = GetShouldBeAccentuated(word);
            var couldBeAccentuated = word.PossibleAccentuations;
            if (!couldBeAccentuated.Any())
                throw new UnknownAccentuationException(word);
            
            var setAccentuation = TrySetAccentuation(word, shouldBeAccentuated, couldBeAccentuated);
            if (!setAccentuation && word.SyllableTokens.Count > 1)
                word.SetAccentuation(couldBeAccentuated[0]);
            _currentSyllableIndex += word.SyllableTokens.Count;
        }
    }

    private List<int> GetShouldBeAccentuated(IWordToken word)
    {
        List<int> shouldBeAccentuated = new();
        for (var i = 0; i < word.SyllableTokens.Count; i++)
            if (_rhythm.SyllableShouldBeAccentuated(i + _currentSyllableIndex))
                shouldBeAccentuated.Add(i);

        return shouldBeAccentuated;
    }

    private static bool TrySetAccentuation(IWordToken word, List<int> shouldBeAccentuated, IReadOnlyList<int> couldBeAccentuated)
    {
        foreach (var should in shouldBeAccentuated)
        {
            if (!couldBeAccentuated.Contains(should)) 
                continue;
            
            word.SetAccentuation(should);
            return true;
        }

        return false;
    }
}