public class Solution 
{
    public void MoveZeroes(int[] nums)
    {
        var arrayIterator = 0;
        var nonZeroesIterator = 0;

        while (arrayIterator < nums.Length && nonZeroesIterator < nums.Length)
        {
            if (nums[arrayIterator] == 0 && arrayIterator < nums.Length)
            {
                while (nonZeroesIterator < nums.Length && nums[nonZeroesIterator] == 0 || nonZeroesIterator < arrayIterator)
                {
                    nonZeroesIterator++;
                }

                if (nonZeroesIterator == nums.Length || nonZeroesIterator <= arrayIterator)
                {
                    break;
                }
                
                (nums[arrayIterator], nums[nonZeroesIterator]) = (nums[nonZeroesIterator], nums[arrayIterator]);
            }

            arrayIterator++;
        }
    }
}