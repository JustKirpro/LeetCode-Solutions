public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (first, second) => first[1].CompareTo(second[1]));
        
        var result = 0;
        var currentIntervalEnd = int.MinValue;

        foreach (var interval in intervals)
        {
            var intervalStart = interval[0];
            var intervalEnd = interval[1];

            if (intervalStart < currentIntervalEnd)
            {
                result++;
            }
            else
            {
                currentIntervalEnd = intervalEnd; 
            }
        }

        return result;
    }
}