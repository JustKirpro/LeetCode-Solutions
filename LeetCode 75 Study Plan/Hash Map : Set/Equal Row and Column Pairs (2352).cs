public class Solution 
{
    public int EqualPairs(int[][] grid)
    {
        var rows = new Dictionary<int, int>();

        for (var i = 0; i < grid.Length; i++)
        {
            var row = new int[grid.Length];
            
            for (var j = 0; j < grid.Length; j++)
            {
                row[j] = grid[i][j];
            }

            var rowHash = GetArrayHashCode(row);
            rows.TryGetValue(rowHash, out var currentCount);
            rows[rowHash] = currentCount + 1;
        }
        
        var columns = new Dictionary<int, int>();

        for (var i = 0; i < grid.Length; i++)
        {
            var column = new int[grid.Length];

            for (var j = 0; j < grid.Length; j++)
            {
                column[j] = grid[j][i];
            }

            var columnHash = GetArrayHashCode(column);
            columns.TryGetValue(columnHash, out var currentCount);
            columns[columnHash] = currentCount + 1;
        }

        var result = 0;

        foreach (var (key, value) in rows)
        {
            if (columns.TryGetValue(key, out var column))
            {
                result += value * column;
            }
        }

        return result;
    }

    private static int GetArrayHashCode(int[] array) => array.Aggregate(0, (current, hash) => HashCode.Combine(hash, current));
}