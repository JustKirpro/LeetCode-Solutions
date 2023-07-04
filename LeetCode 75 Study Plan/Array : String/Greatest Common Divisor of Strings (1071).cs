public class Solution
{
    public string GcdOfStrings(string str1, string str2) 
    {
        if (str1 + str2 != str2 + str1)
        {
            return string.Empty;
        }

        var firstStringLength = str1.Length;
        var secondStringLength = str2.Length;
        
        while (secondStringLength != 0)
        {
            var remainder = firstStringLength % secondStringLength;
            firstStringLength = secondStringLength;
            secondStringLength = remainder;
        }
 
        return str1[..firstStringLength];
    }
}