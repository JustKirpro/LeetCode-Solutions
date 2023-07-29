public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var stack = new Stack<int>();

        for (var i = temperatures.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && temperatures[i] >= temperatures[stack.Peek()])
            {
                stack.Pop();
            }

            if (stack.Count > 0)
            {
                result[i] = stack.Peek() - i;
            }

            stack.Push(i);
        }

        return result;
    }
}