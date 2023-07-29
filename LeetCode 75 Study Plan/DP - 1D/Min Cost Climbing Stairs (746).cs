public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var prevPrevCost = cost[0];
        var prevCost = cost[1];
        
        for (var i = 2; i < cost.Length; i++)
        {
            var tempCost = prevCost;
            prevCost = cost[i] + Math.Min(prevCost, prevPrevCost);
            prevPrevCost = tempCost;
        }

        return Math.Min(prevCost, prevPrevCost);
    }
}