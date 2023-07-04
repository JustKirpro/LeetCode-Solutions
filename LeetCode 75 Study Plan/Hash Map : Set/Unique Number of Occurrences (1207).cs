public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var numbersOccurrences = new Dictionary<int, int>();

        foreach (var number in arr)
        {
            numbersOccurrences.TryGetValue(number, out var currentCount);
            numbersOccurrences[number] = currentCount + 1;
        }

        return numbersOccurrences.Values.Distinct().Count() == numbersOccurrences.Values.Count;
    }
}