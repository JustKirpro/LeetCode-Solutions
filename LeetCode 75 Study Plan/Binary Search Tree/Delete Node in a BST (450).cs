public class Solution
{
    public TreeNode? DeleteNode(TreeNode? root, int key)
    {
        if (root is null)
        {
            return root;
        }

        if (root.val < key)
        {
            root.right = DeleteNode(root.right, key);
        }
        else if (root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        }
        else
        {
            root = DeleteNode(root);
        }

        return root;
    }

    private TreeNode? DeleteNode(TreeNode node)
    {
        if (node.left is null)
        {
            return node.right;
        }
            
        if (node.right is null)
        {
            return node.left;
        }

        var minValue = GetMinValue(node.right);
        node.val = minValue;
        node.right = DeleteNode(node.right, minValue);
        return node;
    }

    private int GetMinValue(TreeNode node) => node.left is null ? node.val : GetMinValue(node.left);
}