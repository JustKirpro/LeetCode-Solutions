public class Solution
{
    private int _counter;
    
    public int MinReorder(int n, int[][] connections)
    {
        var graph = new Dictionary<int, List<(int, bool)>>();

        for (var i = 0; i < n; i++)
        {
            graph[i] = new List<(int, bool)>();
        }
        
        foreach (var connection in connections)
        {
            var source = connection[0];
            var destination = connection[1];
            graph[source].Add((destination, true));
            graph[destination].Add((source, false));
        }
        
        var visited = new HashSet<int>();
        DepthFirstSearch(graph, visited, 0);
        return _counter;
    }

    private void DepthFirstSearch(Dictionary<int, List<(int, bool)>> graph, HashSet<int> visited, int current)
    {
        visited.Add(current);

        foreach (var (city, isPresented) in graph[current])
        {
            if (visited.Contains(city))
            {
                continue;
            }
            
            DepthFirstSearch(graph, visited, city);
            _counter += isPresented ? 1 : 0;
        }
    }
}