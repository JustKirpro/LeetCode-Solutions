public class Solution
{
    public string DecodeString(string s)
    {
        var stack = new Stack<(string PreviousString, int RepeatNumber)>();
        var stringBuilder = new StringBuilder(s.Length);
        var number = 0;
        
        foreach (var character in s)
        {
            if (char.IsDigit(character))
            {
                number = number * 10 + character - '0';
            }
            else if (character == '[')
            {
                var currentString = stringBuilder.ToString();
                stack.Push((currentString, number));
                stringBuilder.Clear();
                number = 0;
            }
            else if (character == ']')
            {
                var (previousString, repeatNumber) = stack.Pop();
                var currentString = stringBuilder.ToString();
                stringBuilder.Clear();
                stringBuilder.Append(previousString);
                
                for (var i = 0; i < repeatNumber; i++)
                {
                    stringBuilder.Append(currentString);
                }
            }
            else
            {
                stringBuilder.Append(character);
            }
        }
        
        return stringBuilder.ToString();
    }
}