namespace WordSyllabler;

public class Syllabler
{
    private const string Vowels = "аоуиіеяюєї";
    
    public int CountSyllables(string text)
    {
        if (text is null)
            throw new ArgumentNullException();
        
        var lower = text.ToLowerInvariant();
        return lower.Count(IsVowel);
    }

    private bool IsVowel(char symbol) => 
        Vowels.Contains(symbol);
}