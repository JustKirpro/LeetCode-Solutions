public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (first, second) => first[1].CompareTo(second[1]));
        
        var result = 0;
        var currentStart = int.MinValue;
        var currentEnd = int.MinValue;

        foreach (var interval in points)
        {
            var start = interval[0];
            var end = interval[1];
            
            if (start > currentEnd && start != currentStart && end != currentEnd)
            {
                result++;
                currentStart = start;
                currentEnd = end;
            }
        }

        return result > 0 ? result : 1;
    }
}