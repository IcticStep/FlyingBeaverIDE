﻿using Domain.Analysing.Tokens.Api.Concrete;

namespace Domain.Analysing.Tokens.Concrete;

public class SyllableToken : Token, ISyllableToken
{
    public SyllableToken(string vowel, int position, int absolutePosition = 0)
        : base(position, absolutePosition) =>
        Vowel = vowel;

    public string Vowel { get; }
    public bool IsAccentuated { get; private set; }

    public void Accentuate() => 
        IsAccentuated = true;

    public override string ToString() => $"{Vowel}:{{{Position}}}";

    public override bool Equals(object? obj)
    {
        if (obj is not ISyllableToken other) 
            return false;

        return Vowel == other.Vowel 
               && Position == other.Position;
    }
}