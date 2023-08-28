public class Solution
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        var sortedTuples = GetSortedTuplesArray(nums1, nums2);
        var priorityQueue = new PriorityQueue<int, int>();
        
        var currentSum = 0L;

        for (var i = 0; i < k; i++)
        {
            currentSum += sortedTuples[i].First;
            priorityQueue.Enqueue(sortedTuples[i].First, sortedTuples[i].First);
        }

        var min = sortedTuples[k - 1].Second;
        var result = currentSum * min;

        for (var i = k; i < sortedTuples.Length; i++)
        {
            currentSum += sortedTuples[i].First - priorityQueue.Dequeue();
            min = sortedTuples[i].Second;
            result = Math.Max(result, currentSum * min);
            priorityQueue.Enqueue(sortedTuples[i].First, sortedTuples[i].First);
        }

        return result;
    }

    private static (int First, int Second)[] GetSortedTuplesArray(int[] nums1, int[] nums2)
    {
        var numbers = new (int First, int Second)[nums1.Length];
        
        for (var i = 0; i < nums1.Length; i++)
        {
            numbers[i] = (nums1[i], nums2[i]);
        }
        
        Array.Sort(numbers, (first, second) => second.Second - first.Second);
        return numbers;
    }
}