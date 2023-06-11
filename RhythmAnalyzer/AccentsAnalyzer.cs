using DataStorage;
using DataStorage.Accentuations;
using Domain.Tokens.Api.Concrete;

namespace RhythmAnalyzer;

public class AccentsAnalyzer
{
    public AccentsAnalyzer(DataBaseCredentials credentials) => 
        _accentuationsRepository = new AccentuationRepository(credentials);

    private readonly IAccentuationsRepository _accentuationsRepository;

    public void SetPossibleAccentuations(IWordToken wordToken)
    {
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