public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        var maxHeight = 0;
        var currentHeight = 0;

        foreach (var height in gain)
        {
            currentHeight += height;

            if (currentHeight > maxHeight)
            {
                maxHeight = currentHeight;
            }
        }

        return maxHeight;
    }
}