public class Solution
{
    public IList<int> RightSideView(TreeNode? root)
    {
        var seenValues = new List<int>();
        TraverseRightVertices(root, 0, seenValues);
        return seenValues;
    }

    private void TraverseRightVertices(TreeNode? node, int height, List<int> seenValues)
    {
        if (node is null)
        {
            return;
        }
        
        if (height == seenValues.Count)
        {
            seenValues.Add(node.val);
        }

        TraverseRightVertices(node.right, height + 1, seenValues);
        TraverseRightVertices(node.left, height + 1, seenValues);
    }
}