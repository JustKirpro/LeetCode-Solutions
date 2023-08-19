public class Solution
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        var queue = new Queue<(int, int, int)>();
        var visited = new HashSet<(int, int)>();
        queue.Enqueue((entrance[0], entrance[1], 0));

        while (queue.Count > 0)
        {
            var (y, x, count) = queue.Dequeue();
            
            if ((y == 0 || y == maze.Length - 1 || x == 0 || x == maze[0].Length - 1) && (y != entrance[0] || x != entrance[1]))
            {
                return count;
            }

            if (visited.Contains((x, y)))
            {
                continue;
            }

            visited.Add((x, y));

            if (y > 0 && maze[y - 1][x] == '.')
            {
                queue.Enqueue((y - 1, x, count + 1));
            }

            if (x < maze[0].Length - 1 && maze[y][x + 1] == '.')
            {
                queue.Enqueue((y, x + 1, count + 1));
            }

            if (y < maze.Length - 1 && maze[y + 1][x] == '.')
            {
                queue.Enqueue((y + 1, x, count + 1));
            }

            if (x > 0 && maze[y][x - 1] == '.')
            {
                queue.Enqueue((y, x - 1, count + 1));
            }
        }

        return -1;
    }
}