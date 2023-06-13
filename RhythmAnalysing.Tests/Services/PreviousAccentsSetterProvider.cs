using DataStorage.Accentuations;
using RhythmAnalysing.Services;

namespace RhythmAnalysing.Tests.Services;

public static class PreviousAccentsSetterProvider
{
    private static readonly PreviousAccentsSetter _previousAccentsSetter;

    static PreviousAccentsSetterProvider()
    {
        var databaseCredentials = DatabaseCredentialsProvider.DatabaseCredentials;
        _previousAccentsSetter = new(new AccentuationsRemoteRepository(databaseCredentials));
    }
    
    public static PreviousAccentsSetter CreateAccentsAnalyzer() => 
        _previousAccentsSetter;
}