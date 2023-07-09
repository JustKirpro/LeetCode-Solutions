public class Solution 
{
    public int LongestOnes(int[] nums, int k) 
    {
        var leftBound = 0;
        var maxSubarrayLength = 0;
        var zeroes = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            zeroes += nums[i] == 0 ? 1 : 0;
            
            while (zeroes > k)
            {
                zeroes -= nums[leftBound] == 0 ? 1 : 0;
                leftBound++;
            }

            var currentSubarrayLength = i - leftBound + 1;
            maxSubarrayLength = Math.Max(currentSubarrayLength, maxSubarrayLength);
        }

        return maxSubarrayLength;
    }
}