public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        var visitedCities = new HashSet<int>();
        var provincesNumber = 0;

        for (var i = 0; i < isConnected.Length; i++)
        {
            if (!visitedCities.Contains(i))
            {
                provincesNumber++;
                DepthFirstSearch(isConnected, i, visitedCities);
            }
        }

        return provincesNumber;
    }

    private void DepthFirstSearch(int[][] isConnected, int cityNumber, HashSet<int> visitedCities)
    {
        visitedCities.Add(cityNumber);

        for (var i = 0; i < isConnected.Length; i++)
        {
            if (isConnected[cityNumber][i] == 1 && !visitedCities.Contains(i))
            {
                DepthFirstSearch(isConnected, i, visitedCities);
            }
        }
    }
}