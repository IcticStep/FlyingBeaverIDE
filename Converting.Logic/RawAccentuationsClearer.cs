﻿using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using ConsoleHelpers.Core;
using HtmlParserSlovnyk.Domain;

namespace Converting.Logic;

public class RawAccentuationsClearer : ILinearHelper
{
    private const int MaxAccentuationsExpected = 3;
    private readonly JsonSerializerOptions _jsonOptions = new()
    {
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
        WriteIndented = true
    };

    private IEnumerable<WordParsedContent> _rawAccentuations = default!;
    private IEnumerable<WordParsedContent> _result = Array.Empty<WordParsedContent>();

    public string Input
    {
        set
        {
            var parsed = JsonSerializer.Deserialize<List<WordParsedContent>>(value, _jsonOptions);
            if (parsed is null || !parsed.Any())
                throw new ArgumentException("Invalid json!");
            
            _rawAccentuations = parsed;
        }
    }

    public string Output => JsonSerializer.Serialize(_result, _jsonOptions);
    
    public void Proceed() =>
        _result = _rawAccentuations
            .Select(RemoveApostrophes)
            .Where(IsNotBroken)
            .Select(Trim)
            .RemoveDuplicates()
            .ToList();

    private static WordParsedContent RemoveApostrophes(WordParsedContent parsed) => 
        new(RemoveApostrophe(parsed.Word),
            RemoveApostrophe(parsed.ParsedContent));

    private static bool IsNotBroken(WordParsedContent parsed) =>
        IsNotBrokenByLength(parsed);

    private static WordParsedContent Trim(WordParsedContent parsed) =>
        new(parsed.Word.Trim(), parsed.ParsedContent.Trim());

    private static string RemoveApostrophe(string word) =>
        word
            .Replace("'", "")
            .Replace("\u0027", "")
            .Replace("’","")
            .Replace("\u2019","");

    private static bool IsNotBrokenByLength(WordParsedContent parsed) =>
        parsed.ParsedContent.Length <= parsed.Word.Length + MaxAccentuationsExpected;
}