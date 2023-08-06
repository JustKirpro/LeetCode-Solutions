public class Solution
{
    private static readonly Dictionary<char, List<char>> Dictionary = new()
    {
        ['2'] = new List<char> {'a', 'b', 'c'},
        ['3'] = new List<char> {'d', 'e', 'f'},
        ['4'] = new List<char> {'g', 'h', 'i'},
        ['5'] = new List<char> {'j', 'k', 'l'},
        ['6'] = new List<char> {'m', 'n', 'o'},
        ['7'] = new List<char> {'p', 'q', 'r', 's'},
        ['8'] = new List<char> {'t', 'u', 'v'},
        ['9'] = new List<char> {'w', 'x', 'y', 'z'}
    };

    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
        {
            return new List<string>();
        }
        
        var combinations = new List<string>();
        var combination = new char[digits.Length];

        CreateCombinations(combinations, combination, digits, 0);
        return combinations;
    }

    private static void CreateCombinations(List<string> combinations, char[] combination, string digits, int index)
    {
        if (index == digits.Length)
        {
            var copy = new string(combination);
            combinations.Add(copy);
            return;
        }

        var digit = digits[index];
        var letters = Dictionary[digit];

        foreach (var letter in letters)
        {
            combination[index] = letter;
            CreateCombinations(combinations, combination, digits, index + 1);
        }
    }
}