public class Solution
{
    public int PairSum(ListNode? head)
    {
        var elements = new List<int>();

        while (head is not null)
        {
            elements.Add(head.val);
            head = head.next;
        }

        var i = 0;
        var j = elements.Count - 1;
        var maxSum = 0;
        
        while (i < j)
        {
            var currentSum = elements[i++] + elements[j--];
            maxSum = Math.Max(currentSum, maxSum);
        }

        return maxSum;
    }
}