public class Solution
{
    public int MaxLevelSum(TreeNode root)
    {
        var levelSums = new Dictionary<int, long>();
        FillLevelSums(root, levelSums, 1);
        
        var maxSum = long.MinValue;
        var maxSumLevel = 0;

        foreach (var (level, sum) in levelSums)
        {
            if (sum > maxSum)
            {
                maxSum = sum;
                maxSumLevel = level;
            }
        }

        return maxSumLevel;
    }

    private void FillLevelSums(TreeNode? node, Dictionary<int, long> levelSums, int level)
    {
        if (node is null)
        {
            return;
        }

        levelSums.TryGetValue(level, out var sum);
        levelSums[level] = sum + node.val;

        FillLevelSums(node.left, levelSums, level + 1);
        FillLevelSums(node.right, levelSums, level + 1);
    }
}