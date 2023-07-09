public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var currentSubarraySum = 0;

        for (var i = 0; i < k; i++)
        {
            currentSubarraySum += nums[i];
        }

        var maxSubarraySum = currentSubarraySum;

        for (var i = k; i < nums.Length; i++)
        {
            currentSubarraySum += nums[i] - nums[i - k];

            if (currentSubarraySum > maxSubarraySum)
            {
                maxSubarraySum = currentSubarraySum;
            }
        }

        return (double) maxSubarraySum / k;
    }
}