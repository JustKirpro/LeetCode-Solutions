public class Solution 
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var firstTreeLeaves = new List<int>();
        GetTreeLeaves(root1, firstTreeLeaves);

        var secondTreeLeaves = new List<int>();
        GetTreeLeaves(root2, secondTreeLeaves);

        if (firstTreeLeaves.Count != secondTreeLeaves.Count)
        {
            return false;
        }
        
        return !firstTreeLeaves
            .Where((leafValue, index) => leafValue != secondTreeLeaves[index])
            .Any();
    }

    private static void GetTreeLeaves(TreeNode node, List<int> leaves)
    {
        if (node.left is null && node.right is null)
        {
            leaves.Add(node.val);
            return;
        }

        if (node.left is not null)
        {
            GetTreeLeaves(node.left, leaves);
        }

        if (node.right is not null)
        {
            GetTreeLeaves(node.right, leaves);
        }
    }
}