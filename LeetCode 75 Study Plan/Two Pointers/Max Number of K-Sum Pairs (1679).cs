public class Solution 
{
    public int MaxOperations(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int>();
        var usedValues = new HashSet<int>();

        foreach (var number in nums)
        {
            dictionary.TryGetValue(number, out var count);
            dictionary[number] = count + 1;
        }

        var operationsNumber = 0;

        foreach (var (number, count) in dictionary)
        {
            if (!usedValues.Contains(number))
            {
                var oppositeNumber = k - number;
                dictionary.TryGetValue(oppositeNumber, out var oppositeCount);

                operationsNumber += number == oppositeNumber ? count / 2 : Math.Min(count, oppositeCount);
            
                usedValues.Add(number);
                usedValues.Add(oppositeNumber);
            }
        }

        return operationsNumber;
    }
}