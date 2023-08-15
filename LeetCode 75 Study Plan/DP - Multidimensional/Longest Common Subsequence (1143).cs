public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var previousRow = new int[text2.Length + 1];
        var currentRow = new int[text2.Length + 1];
        
        for (var i = 1; i <= text1.Length; i++)
        {
            for (var j = 1; j <= text2.Length; j++)
            {
                currentRow[j] = Math.Max(previousRow[j], currentRow[j - 1]);

                if (text1[i - 1] == text2[j - 1])
                {
                    currentRow[j] = Math.Max(currentRow[j], previousRow[j - 1] + 1);
                }
            }

            (previousRow, currentRow) = (currentRow, previousRow);
        }

        return previousRow[text2.Length];
    }
}