public class Solution 
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var prefixProducts = new int[nums.Length];
        prefixProducts[0] = 1;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            prefixProducts[i + 1] = prefixProducts[i] * nums[i];
        }
        
        var postfixProducts = new int[nums.Length];
        postfixProducts[^1] = 1;

        for (var i = nums.Length - 1; i > 0; i--)
        {
            postfixProducts[i - 1] = postfixProducts[i] * nums[i];
        }

        var result = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = prefixProducts[i] * postfixProducts[i];
        }
        
        return result;
    }
}