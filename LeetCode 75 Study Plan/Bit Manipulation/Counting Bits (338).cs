public class Solution
{
    public int[] CountBits(int n)
    {
        if (n == 0)
        {
            return new[] {0};
        }

        var result = new int[n + 1];
        
        for (var i = 1; i <= n; i++)
        {
            result[i] = result[i / 2] + i % 2;
        }

        return result;
    }
}