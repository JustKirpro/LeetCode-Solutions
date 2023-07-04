public class Solution 
{
    public string ReverseWords(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var reversedWords = words
            .Reverse()
            .ToList();

        return string.Join(' ', reversedWords);
    }
}