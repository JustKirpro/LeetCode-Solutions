public class Solution
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);
        var result = new int[spells.Length];

        for (var i = 0; i < spells.Length; i++)
        {
            var spellPower = spells[i];
            var successfulPairsNumber = GetSuccessfulPairsNumber(potions, spellPower, success);
            result[i] = successfulPairsNumber;
        }

        return result;
    }

    private static int GetSuccessfulPairsNumber(int[] potions, int spellPower, long success)
    {
        var left = 0;
        var right = potions.Length - 1;
        var resultIndex = -1;

        while (left <= right)
        {
            var middle = left + (right - left) / 2;
            var potionPower = potions[middle];
            var productPower = (long)spellPower * potionPower;
            
            if (productPower >= success)
            {
                resultIndex = middle;
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return resultIndex > -1 ? potions.Length - resultIndex : 0;
    }
}