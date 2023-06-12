using DataStorage;
using Microsoft.Extensions.Configuration;
using RhythmAnalysing.Services;
using RhythmAnalysing.Tests.Tests.Components;

namespace RhythmAnalysing.Tests.Services;

public static class PreviousAccentsSetterProvider
{
    private static readonly PreviousAccentsSetter _previousAccentsSetter;

    static PreviousAccentsSetterProvider()
    {
        var databaseCredentials = DatabaseCredentialsProvider.DatabaseCredentials;
        _previousAccentsSetter = new(databaseCredentials);
    }
    
    public static PreviousAccentsSetter CreateAccentsAnalyzer() => 
        _previousAccentsSetter;
}