public class Solution
{
    public long TotalCost(int[] costs, int k, int candidates)
    {
        var leftQueue = new PriorityQueue<int, int>();
        var rightQueue = new PriorityQueue<int, int>();

        for (var i = 0; i < candidates; i++)
        {
            leftQueue.Enqueue(costs[i], costs[i]);
        }

        for (var i = 0; i < Math.Min(costs.Length - candidates, candidates); i++)
        {
            rightQueue.Enqueue(costs[^(i + 1)], costs[^(i + 1)]);
        }

        var cost = 0L;
        var leftPointer = candidates;
        var rightPointer = costs.Length - candidates - 1;

        for (var i = 0; i < k; i++)
        {
            var left = leftQueue.Count > 0 ? leftQueue.Peek() : int.MaxValue;
            var right = rightQueue.Count > 0 ? rightQueue.Peek() : int.MaxValue;

            if (left <= right)
            {
                cost += leftQueue.Dequeue();

                if (leftPointer <= rightPointer)
                {
                    leftQueue.Enqueue(costs[leftPointer], costs[leftPointer]);
                    leftPointer++;
                }
            }
            else
            {
                cost += rightQueue.Dequeue();

                if (rightPointer >= leftPointer)
                {
                    rightQueue.Enqueue(costs[rightPointer], costs[rightPointer]);
                    rightPointer--;
                }
            }
        }

        return cost;
    }
}