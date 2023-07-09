public class Solution 
{
    public int MaxVowels(string s, int k)
    {
        var substringVowelsCount = 0;

        for (var i = 0; i < k; i++)
        {
            if (IsVowel(s[i]))
            {
                substringVowelsCount++;
            }
        }

        var maxSubstringVowels = substringVowelsCount;
        
        for (var i = k; i < s.Length; i++)
        {
            if (IsVowel(s[i]))
            {
                substringVowelsCount++;
            }

            if (IsVowel(s[i - k]))
            {
                substringVowelsCount--;
            }

            if (substringVowelsCount > maxSubstringVowels)
            {
                maxSubstringVowels = substringVowelsCount;
            }
        }
        
        return maxSubstringVowels;
    }

    private static bool IsVowel(char character) => "aeiou".Contains(character);
}