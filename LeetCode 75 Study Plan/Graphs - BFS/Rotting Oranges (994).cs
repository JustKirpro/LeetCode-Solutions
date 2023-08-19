public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        var queue = GetRottenOranges(grid);
        var visited = new HashSet<(int X, int Y)>();
        var maxMinute = 0;

        while (queue.Count > 0)
        {
            var (x, y, minute) = queue.Dequeue();

            if (visited.Contains((x, y)))
            {
                continue;
            }

            visited.Add((x, y));
            grid[y][x] = 2;
            maxMinute = Math.Max(minute, maxMinute);

            if (y > 0 && grid[y - 1][x] == 1)
            {
                queue.Enqueue((x, y - 1, minute + 1));
            }

            if (x < grid[0].Length - 1 && grid[y][x + 1] == 1)
            {
                queue.Enqueue((x + 1, y, minute + 1));
            }

            if (y < grid.Length - 1 && grid[y + 1][x] == 1)
            {
                queue.Enqueue((x, y + 1, minute + 1));
            }
            
            if (x > 0 && grid[y][x - 1] == 1)
            {
                queue.Enqueue((x - 1, y, minute + 1));
            }
        }

        return IsEveryOrangeRotten(grid) ? maxMinute : -1;
    }

    private static Queue<(int X, int Y, int Minute)> GetRottenOranges(int[][] grid)
    {
        var queue = new Queue<(int X, int Y, int Minute)>();

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                var cell = grid[i][j];

                if (cell == 2)
                {
                    queue.Enqueue((j, i, 0));
                }
            }
        }

        return queue;
    }

    private static bool IsEveryOrangeRotten(int[][] grid)
    {
        foreach (var row in grid)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                var cell = row[j];

                if (cell == 1)
                {
                    return false;
                }
            }
        }

        return true;
    }
}