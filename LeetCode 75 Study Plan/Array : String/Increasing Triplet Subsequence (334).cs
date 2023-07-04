public class Solution 
{
    public bool IncreasingTriplet(int[] nums)
    {
        var leftBound = int.MaxValue;
        var rightBound = int.MaxValue;

        foreach (var number in nums)
        {
            if (number <= leftBound)
            {
                leftBound = number;
            }
            else if (number <= rightBound)
            {
                rightBound = number;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}