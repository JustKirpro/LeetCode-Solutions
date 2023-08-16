public class Solution
{
    public TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode p, TreeNode q)
    {
        if (root is null || root == p || root == q)
        {
            return root;
        }

        var leftSubtree = LowestCommonAncestor(root.left, p, q);
        var rightSubtree = LowestCommonAncestor(root.right, p, q);

        if (leftSubtree is null)
        {
            return rightSubtree;
        }

        return rightSubtree is null ? leftSubtree : root;
    }
}