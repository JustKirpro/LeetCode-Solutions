public class Solution
{
    public int MinFlips(int a, int b, int c)
    {
        var result = 0;

        for (var i = 0; i < 32; i++)
        {
            var isA = (a & (1 << i)) != 0;
            var isB = (b & (1 << i)) != 0;
            var isC = (c & (1 << i)) != 0;

            if (isC && !(isA || isB))
            {
                result += 1;
            }
            else if (!isC && (isA || isB))
            {
                result += isA && isB ? 2 : 1;
            }
        }

        return result;
    }
}