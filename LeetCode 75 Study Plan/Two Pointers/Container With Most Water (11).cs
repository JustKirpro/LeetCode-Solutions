public class Solution 
{
    public int MaxArea(int[] height)
    {
        var leftBorder = 0;
        var rightBorder = height.Length - 1;
        var maxArea = 0;

        while (leftBorder < rightBorder)
        {
            var area = (rightBorder - leftBorder) * Math.Min(height[leftBorder], height[rightBorder]);
            maxArea = Math.Max(area, maxArea);

            if (height[leftBorder] < height[rightBorder])
            {
                leftBorder++;
            }
            else
            {
                rightBorder--;
            }
        }

        return maxArea;
    }
}