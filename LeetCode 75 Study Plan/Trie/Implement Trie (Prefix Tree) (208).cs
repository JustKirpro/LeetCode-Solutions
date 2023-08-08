public class Trie
{
    private readonly Node _root = new();
    
    public void Insert(string word)
    {
        var node = _root;
        
        foreach (var letter in word)
        {
            var letters = node.Letters;
            letters.TryAdd(letter, new Node());
            node = letters[letter];
        }

        node.IsWordEnd = true;
    }

    public bool Search(string word, bool fullMath = true)
    {
        var node = _root;

        foreach (var letter in word)
        {
            var letters = node.Letters;

            if (!letters.ContainsKey(letter))
            {
                return false;
            }

            node = letters[letter];
        }

        return node.IsWordEnd || !fullMath;
    }

    public bool StartsWith(string prefix) => Search(prefix, false);

    private class Node
    {
        public Dictionary<char, Node> Letters { get; set; } = new();
        public bool IsWordEnd { get; set; }
    }
}