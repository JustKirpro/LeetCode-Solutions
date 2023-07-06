public class Solution 
{
    public int PivotIndex(int[] nums)
    {
        var rightPrefixSum = new int[nums.Length];

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            rightPrefixSum[i] = rightPrefixSum[i + 1] + nums[i + 1];
        }

        var previousLeftSum = 0;
        
        for (var i = 0; i < nums.Length; i++)
        {
            previousLeftSum += i - 1 >= 0 ? nums[i - 1] : 0;

            if (previousLeftSum == rightPrefixSum[i])
            {
                return i;
            }
        }
        
        return -1;
    }
}