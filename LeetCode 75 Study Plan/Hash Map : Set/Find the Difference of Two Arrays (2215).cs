public class Solution 
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var firstListElements = new HashSet<int>(nums1);
        var secondListElements = new HashSet<int>(nums2);

        var firstListUniques = new HashSet<int>(firstListElements);
        firstListUniques.ExceptWith(secondListElements);

        var secondListUniques = new HashSet<int>(secondListElements);
        secondListUniques.ExceptWith(firstListElements);
        
        return new List<IList<int>>
        {
            firstListUniques.ToList(),
            secondListUniques.ToList()
        };
    }
}