public class Solution
{
    public int MaxDepth(TreeNode root) => root is null ? 0 : Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
}