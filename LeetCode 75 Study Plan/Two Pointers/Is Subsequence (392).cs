public class Solution 
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }
        
        var currentCharacterIndex = 0;
        
        foreach (var character in t)
        {
            if (character == s[currentCharacterIndex])
            {
                currentCharacterIndex++;
                
                if (currentCharacterIndex == s.Length)
                {
                    return true;
                }
            }
        }

        return false;
    }
}