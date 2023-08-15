public class Solution
{
    public int UniquePaths(int m, int n)
    {
        var dp = new int[n];
        Array.Fill(dp, 1);
        
        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                dp[j] += dp[j - 1];
            }
        }

        return dp[n - 1];
    }
}