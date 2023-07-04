public class Solution 
{
    public bool CloseStrings(string word1, string word2) 
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }

        var characters = new HashSet<char>(word1);
        
        if (word2.Any(character => !characters.Contains(character)))
        {
            return false;
        }

        var firstWordSortedFrequencies = GetSortedFrequencies(word1);
        var secondWordSortedFrequencies = GetSortedFrequencies(word2);

        return !firstWordSortedFrequencies
            .Where((frequency, index) => frequency != secondWordSortedFrequencies[index])
            .Any();
    }

    private static int[] GetSortedFrequencies(string word)
    {
        var wordFrequencies = new Dictionary<char, int>();
        
        foreach (var character in word)
        {
            wordFrequencies.TryGetValue(character, out var currentCount);
            wordFrequencies[character] = currentCount + 1;
        }

        return wordFrequencies
            .Values
            .OrderBy(value => value)
            .ToArray();
    }
}