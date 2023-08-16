public class Solution 
{
    public int GoodNodes(TreeNode root) => TraverseTree(root, int.MinValue, 0);

    private static int TraverseTree(TreeNode node, int currentPathMax, int goodNodesCount)
    {
        if (node.val >= currentPathMax)
        {
            currentPathMax = node.val;
            goodNodesCount++;
        }

        if (node.left is not null)
        {
            goodNodesCount = TraverseTree(node.left, currentPathMax, goodNodesCount);
        }

        if (node.right is not null)
        {
            goodNodesCount = TraverseTree(node.right, currentPathMax, goodNodesCount);
        }

        return goodNodesCount;
    }
}