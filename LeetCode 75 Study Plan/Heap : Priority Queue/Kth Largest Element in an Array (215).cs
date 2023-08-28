public class Solution
{
    private readonly Random _random = new();
    
    public int FindKthLargest(int[] nums, int k)
    {
        var numbers = new List<int>(nums);
        return QuickSelect(numbers, k);
    }

    private int QuickSelect(List<int> numbers, int k)
    {
        var pivotIndex = _random.Next(numbers.Count);
        var pivotValue = numbers[pivotIndex];

        var left = new List<int>();
        var middle = new List<int>();
        var right = new List<int>();

        foreach (var number in numbers)
        {
            if (number < pivotValue)
            {
                left.Add(number);
            }
            else if (number == pivotValue)
            {
                middle.Add(number);
            }
            else
            {
                right.Add(number);
            }
        }

        if (right.Count >= k)
        {
            return QuickSelect(right, k);
        }

        return right.Count + middle.Count >= k 
            ? pivotValue 
            : QuickSelect(left, k - middle.Count - right.Count);
    }
}