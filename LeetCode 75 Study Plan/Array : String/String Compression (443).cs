public class Solution 
{
    public int Compress(char[] chars)
    {
        var occurrences = new List<(char Character, int Count)> {(chars[0], 1)};

        for (var i = 1; i < chars.Length; i++)
        {
            var previous = occurrences[^1];
            var currentCharacter = chars[i];

            if (currentCharacter == previous.Character)
            {
                occurrences[^1] = (previous.Character, ++previous.Count);
            }
            else
            {
                occurrences.Add((currentCharacter, 1));
            }
        }

        var totalLength = 0;
        var index = 0;

        foreach (var (character, count) in occurrences)
        {
            chars[index++] = character;
            totalLength++;

            if (count > 1)
            {
                var characters = count.ToString().ToCharArray();

                foreach (var digitCharacter in characters)
                {
                    chars[index++] = digitCharacter;
                }

                totalLength += characters.Length;   
            }
        }

        return totalLength;
    }
}