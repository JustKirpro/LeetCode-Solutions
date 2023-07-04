public class Solution 
{
    public string MergeAlternately(string word1, string word2)
    {
        var i = 0;
        var j = 0;

        var stringBuilder = new StringBuilder(word1.Length + word2.Length);
        
        while (i < word1.Length && j < word2.Length)
        {
            stringBuilder.Append(word1[i++]);
            stringBuilder.Append(word2[j++]);
        }

        while (i < word1.Length)
        {
            stringBuilder.Append(word1[i++]);
        }

        while (j < word2.Length)
        {
            stringBuilder.Append(word2[j++]);
        }

        return stringBuilder.ToString();
    }
}