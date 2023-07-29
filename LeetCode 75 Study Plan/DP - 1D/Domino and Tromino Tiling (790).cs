public class Solution
{
    private const int Module = 1_000_000_007;

    public int NumTilings(int n) => n switch
    {
        1 => 1,
        2 => 2,
        3 => 5,
        _ => CalculateTilingsNumber(n)
    };

    private static int CalculateTilingsNumber(int n)
    {
        var dp = new long[n];
        dp[0] = 1;
        dp[1] = 2;
        dp[2] = 5;
        
        for (var i = 3; i < n; i++)
        {
            dp[i] = (2 * dp[i - 1] + dp[i - 3]) % Module;
        }

        return (int) dp[n - 1];
    }
}