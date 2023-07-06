public class RecentCounter
{
    private readonly Queue<int> _queue = new();
    
    public RecentCounter() { }
    
    public int Ping(int t)
    {
        _queue.Enqueue(t);

        while (_queue.Peek() < t - 3000)
        {
            _queue.Dequeue();
        }

        return _queue.Count;
    }
}