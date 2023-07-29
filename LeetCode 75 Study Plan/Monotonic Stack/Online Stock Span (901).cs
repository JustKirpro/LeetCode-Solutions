public class StockSpanner
{
    private Stack<(int Price, int Result)> _stack = new();

    public int Next(int price)
    {
        var result = 1;

        while (_stack.Count > 0 && _stack.Peek().Price <= price)
        {
            result += _stack.Pop().Result;
        }
        
        _stack.Push((price, result));
        return result;
    }
}