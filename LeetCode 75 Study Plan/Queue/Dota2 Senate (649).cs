public class Solution 
{
    public string PredictPartyVictory(string senate)
    {
        var radiantQueue = new Queue<int>();
        var direQueue = new Queue<int>();
        var index = 0;

        foreach (var senatorSide in senate)
        {
            if (senatorSide == 'R')
            {
                radiantQueue.Enqueue(index++);
            }
            else
            {
                direQueue.Enqueue(index++);
            }
        }

        while (radiantQueue.Count > 0 && direQueue.Count > 0)
        {
            var radiantIndex = radiantQueue.Dequeue();
            var direIndex = direQueue.Dequeue();

            if (radiantIndex < direIndex)
            {
                radiantQueue.Enqueue(index++);
            }
            else
            {
                direQueue.Enqueue(index++);
            }
        }

        return radiantQueue.Count == 0 ? "Dire" : "Radiant";
    }
}