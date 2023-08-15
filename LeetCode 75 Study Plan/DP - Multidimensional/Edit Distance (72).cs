public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        var previousRow = new int[word2.Length + 1];
        var currentRow = new int[word2.Length + 1]; 
        
        for (var i = 0; i <= word2.Length; i++)
        {
            previousRow[i] = i;
        }

        for (var i = 1; i <= word1.Length; i++)
        {
            currentRow[0] = i;
            
            for (var j = 1; j <= word2.Length; j++)
            {
                var insertion = currentRow[j - 1] + 1;
                var deletion = previousRow[j] + 1;
                var match = word1[i - 1] == word2[j - 1] ? previousRow[j - 1] : previousRow[j - 1] + 1;
                currentRow[j] = Math.Min(Math.Min(insertion, deletion), match);
            }

            (previousRow, currentRow) = (currentRow, previousRow);
        }
        
        return previousRow[word2.Length];
    }
}