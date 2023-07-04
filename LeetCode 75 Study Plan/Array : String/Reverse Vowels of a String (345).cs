public class Solution
{
    public string ReverseVowels(string s)
    {
        var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        var encounteredVowels = s
            .Where(character => vowels.Contains(character))
            .ToList();

        var stringBuilder = new StringBuilder(s.Length);
        var currentVowelNumber = 1;
        
        foreach (var character in s)
        {
            var appendingCharacter = vowels.Contains(character) ? encounteredVowels[^currentVowelNumber++] : character; 
            stringBuilder.Append(appendingCharacter);
        }

        return stringBuilder.ToString();
    }
}