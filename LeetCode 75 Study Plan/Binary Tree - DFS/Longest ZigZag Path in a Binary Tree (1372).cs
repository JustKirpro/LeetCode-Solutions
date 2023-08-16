public class Solution
{
    public int LongestZigZag(TreeNode root)
    {
        var leftSubtreeLength = TraverseTree(root, true, 0);
        var rightSubtreeLength = TraverseTree(root, false, 0);
        return Math.Max(leftSubtreeLength, rightSubtreeLength);
    }

    private static int TraverseTree(TreeNode? node, bool isRight, int length)
    {
        if (node is null)
        {
            return length - 1;
        }

        if (isRight)
        {
            var leftSubtreeLength = TraverseTree(node.left, false, length + 1);
            var rightSubtreeLength = TraverseTree(node.right, true, 1);
            return Math.Max(leftSubtreeLength, rightSubtreeLength);
        }
        else
        {
            var leftSubtreeLength = TraverseTree(node.left, false, 1);
            var rightSubtreeLength = TraverseTree(node.right, true, length + 1);
            return Math.Max(leftSubtreeLength, rightSubtreeLength);
        }
    }
}