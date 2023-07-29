public class Solution
{
    public int Rob(int[] nums)
    {
        var prevCost = 0;
        var prevPrevCost = 0;

        foreach (var cost in nums)
        {
            var tempCost = prevCost;
            prevCost = Math.Max(prevCost, prevPrevCost + cost);
            prevPrevCost = tempCost;
        }

        return prevCost;
    }
}