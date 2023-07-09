public class Solution 
{
    public int LongestSubarray(int[] nums)
    {
        var leftBound = 0;
        var maxSubarrayLength = 0;
        var zeroes = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            zeroes += nums[i] == 0 ? 1 : 0;
            
            while (zeroes > 1)
            {
                zeroes -= nums[leftBound] == 0 ? 1 : 0;
                leftBound++;
            }

            var currentSubarrayLength = i - leftBound;
            maxSubarrayLength = Math.Max(currentSubarrayLength, maxSubarrayLength);
        }

        return maxSubarrayLength;
    }
}