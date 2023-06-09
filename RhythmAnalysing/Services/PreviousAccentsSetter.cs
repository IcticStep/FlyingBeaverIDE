﻿using DataStorage;
using DataStorage.Accentuations;
using DataStorage.Accentuations.Api;
using Domain.Analysing.Tokens.Api.Concrete;

namespace RhythmAnalysing.Services;

public class PreviousAccentsSetter
{
    public PreviousAccentsSetter(IReadOnlyAccentuationsRepository accentuationsRepository) => 
        _accentuationsRepository = accentuationsRepository;

    private readonly IReadOnlyAccentuationsRepository _accentuationsRepository;

    public void SetPossibleAccentuations(IWordToken wordToken)
    {
        if (wordToken.SyllableTokens.Count == 1)
        {
            wordToken.SetPossibleAccentuations(0);
        }
        
        var clearedWord = GetClearedWord(wordToken);
        var accentuation = _accentuationsRepository.GetAccentuationSyllable(clearedWord);
        if (accentuation is null)
            return;

        wordToken.SetPossibleAccentuations(accentuation);
    }

    private static string GetClearedWord(IWordToken word) => 
        RemoveApostrophe(word.RawText);

    private static string RemoveApostrophe(string word) =>
        word
            .Replace("'", "")
            .Replace("\u0027", "")
            .Replace("’","")
            .Replace("\u2019","");
}