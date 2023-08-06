public class Solution
{
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        var combinations = new List<IList<int>>();
        var combination = new Stack<int>();

        GenerateCombinations(combinations, combination, n, k, 1);
        return combinations;
    }

    private static void GenerateCombinations(IList<IList<int>> combinations, Stack<int> combination, int target, int size, int number)
    {
        if (target == 0 && combination.Count == size)
        {
            var copy = combination.ToList();
            combinations.Add(copy);
            return;
        }

        if (target < 0)
        {
            return;
        }

        for (var i = number; i <= 9; i++)
        {
            combination.Push(i);
            GenerateCombinations(combinations, combination, target - i, size, i + 1);
            combination.Pop();
        }
    }
}