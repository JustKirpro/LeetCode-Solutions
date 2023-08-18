public class Solution
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var graph = CreateGraph(equations, values);
        var result = new double[queries.Count];

        for (var i = 0; i < queries.Count; i++)
        {
            var numerator = queries[i][0];
            var denominator = queries[i][1];
            result[i] = ProcessQuery(graph, numerator, denominator);
        }

        return result;
    }

    private static double ProcessQuery(Dictionary<string, List<(string, double)>> graph, string numerator, string denominator)
    {
        if (numerator == denominator && graph.ContainsKey(numerator))
        {
            return 1;
        }
        
        var visited = new HashSet<string>();
        return DepthFirstSearch(graph, visited, numerator, denominator);
    }

    private static double DepthFirstSearch(Dictionary<string, List<(string, double)>> graph, HashSet<string> visited, string current, string target)
    {
        visited.Add(current);
        
        if (!graph.ContainsKey(current))
        {
            return -1;
        }

        foreach (var (denominator, value) in graph[current])
        {
            if (visited.Contains(denominator))
            {
                continue;
            }
            
            if (denominator == target)
            {
                return value;
            }

            var evaluatedValue = DepthFirstSearch(graph, visited, denominator, target);

            if (evaluatedValue != -1)
            {
                return evaluatedValue * value;
            }
        }

        return -1;
    }

    private static Dictionary<string, List<(string, double)>> CreateGraph(IList<IList<string>> equations, double[] values)
    {
        var graph = new Dictionary<string, List<(string, double)>>();
        
        for (var i = 0; i < equations.Count; i++)
        {
            var numerator = equations[i][0];
            var denominator = equations[i][1];

            if (!graph.ContainsKey(numerator))
            {
                graph[numerator] = new List<(string, double)>();
            }

            graph[numerator].Add((denominator, values[i]));

            if (!graph.ContainsKey(denominator))
            {
                graph[denominator] = new List<(string, double)>();
            }

            graph[denominator].Add((numerator, 1 / values[i]));
        }

        return graph;
    }
}