public class Solution
{
    private int _pathsNumber;
    
    public int PathSum(TreeNode? root, long targetSum)
    {
        if (root is not null)
        {
            TraverseTree(root, targetSum);
            PathSum(root.left, targetSum);
            PathSum(root.right, targetSum);    
        }
        
        return _pathsNumber;
    }

    private void TraverseTree(TreeNode? node, long targetSum)
    {
        if (node is null)
        {
            return;
        }

        var value = node.val;

        if (value == targetSum)
        {
            _pathsNumber++;
        }

        TraverseTree(node.left, targetSum - value);
        TraverseTree(node.right, targetSum - value);
    }
}