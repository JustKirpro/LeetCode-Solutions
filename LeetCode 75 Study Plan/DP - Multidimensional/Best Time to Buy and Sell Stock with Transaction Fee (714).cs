public class Solution
{
    public int MaxProfit(int[] prices, int fee)
    {
        var buy = -prices[0];
        var sell = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            (buy, sell) = (Math.Max(buy, sell - prices[i]), Math.Max(sell, buy + prices[i] - fee));
        }
        
        return sell;
    }
}