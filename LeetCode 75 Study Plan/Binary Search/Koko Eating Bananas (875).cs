public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        var left = 1;
        var right = piles.Max();

        while (left < right)
        {
            var middle = left + (right - left) / 2;
            var canEat = CanEat(piles, middle, h);

            if (canEat)
            {
                right = middle;
            }
            else
            {
                left = middle + 1;
            }
        }

        return left;
    }

    private static bool CanEat(int[] piles, int speed, int hours)
    {
        var currentHours = 0;

        foreach (var pile in piles)
        {
            currentHours += (pile + speed - 1) / speed;

            if (currentHours > hours)
            {
                return false;
            }
        }

        return true;
    }
}