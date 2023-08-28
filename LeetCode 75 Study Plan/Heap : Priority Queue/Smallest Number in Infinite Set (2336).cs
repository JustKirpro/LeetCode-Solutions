public class SmallestInfiniteSet
{
    private readonly SortedSet<int> _numbers = new();
    private int _currentNumber = 1;

    public int PopSmallest()
    {
        if (_numbers.Count > 0)
        {
            var number = _numbers.Min;
            _numbers.Remove(number);
            return number;
        }

        _currentNumber++;
        return _currentNumber - 1;
    }

    public void AddBack(int num)
    {
        if (_currentNumber > num)
        {
            _numbers.Add(num);
        }
    }
}