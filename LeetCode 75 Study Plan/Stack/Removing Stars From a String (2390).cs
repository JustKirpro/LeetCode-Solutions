public class Solution 
{
    public string RemoveStars(string s)
    {
        var stack = new Stack<char>();

        foreach (var character in s)
        {
            if (character == '*')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(character);   
            }
        }

        var characters = string.Join("", stack).ToCharArray();
        Array.Reverse(characters);
        return new string(characters);
    }
}