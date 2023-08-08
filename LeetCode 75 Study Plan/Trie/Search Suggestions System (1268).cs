public class Trie
{
    public Node Root { get; } = new();
    
    public void Insert(string word)
    {
        var node = Root;
        
        foreach (var letter in word)
        {
            var letters = node.Letters;
            var index = letter - 'a';
            letters[index] ??= new Node();
            node = letters[index]!;
        }

        node.IsWordEnd = true;
    }

    public class Node
    {
        private const int AlphabetSize = 26;
        public Node?[] Letters { get; } = new Node[AlphabetSize];
        public bool IsWordEnd { get; set; }
    }
}

public class Solution
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        var trie = new Trie();

        foreach (var product in products)
        {
            trie.Insert(product);
        }

        return GetSuggestions(trie, searchWord);
    }

    private static IList<IList<string>> GetSuggestions(Trie trie, string searchWord)
    {
        var suggestions = new List<IList<string>>();

        var letter = searchWord[0];
        var node = trie.Root.Letters[letter - 'a'];
        var stack = new Stack<char>();
        stack.Push(letter);

        for (var i = 1; i <= searchWord.Length; i++)
        {
            var currentSuggestions = new List<string>();
            
            if (node is null)
            {
                suggestions.Add(currentSuggestions);
                continue;
            }

            DepthFirstSearch(node, currentSuggestions, stack);
            suggestions.Add(currentSuggestions);

            if (i != searchWord.Length)
            {
                letter = searchWord[i];
                stack.Push(letter);
                node = node.Letters[letter - 'a'];   
            }
        }
        
        return suggestions;
    }

    private static void DepthFirstSearch(Trie.Node node, List<string> suggestions, Stack<char> stack)
    {
        if (suggestions.Count == 3)
        {
            return;
        }
        
        if (node.IsWordEnd)
        {
            var charArray = stack.Reverse().ToArray();
            var word = new string(charArray);
            suggestions.Add(word);
        }
        
        for (var i = 0; i < node.Letters.Length; i++)
        {
            var letter = node.Letters[i];

            if (letter is null)
            {
                continue;
            }

            stack.Push((char) (i + 'a'));
            DepthFirstSearch(letter, suggestions, stack);
            stack.Pop();
        }
    }
}