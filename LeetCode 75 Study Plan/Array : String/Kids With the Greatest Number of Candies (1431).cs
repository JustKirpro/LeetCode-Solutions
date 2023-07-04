public class Solution 
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxCandiesNumber = candies.Max();
        return candies
            .Select(candiesNumber => candiesNumber + extraCandies >= maxCandiesNumber)
            .ToList();
    }
}