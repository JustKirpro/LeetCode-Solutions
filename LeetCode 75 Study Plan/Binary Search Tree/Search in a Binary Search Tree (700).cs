public class Solution
{
    public TreeNode? SearchBST(TreeNode? root, int val)
    {
        if (root is null || root.val == val)
        {
            return root;
        }

        if (root.val > val)
        {
            return SearchBST(root.left, val);
        }

        return SearchBST(root.right, val);
    }
}