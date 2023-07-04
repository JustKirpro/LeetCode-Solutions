public class Solution 
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var flowersLeft = n;

        if (flowersLeft == 0)
        {
            return true;
        }

        for (var i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 1 || i - 1 >= 0 && flowerbed[i - 1] == 1 || i + 1 < flowerbed.Length && flowerbed[i + 1] == 1)
            {
                continue;
            }

            flowerbed[i] = 1;
            flowersLeft--;

            if (flowersLeft == 0)
            {
                return true;
            }
        }

        return false;
    }
}