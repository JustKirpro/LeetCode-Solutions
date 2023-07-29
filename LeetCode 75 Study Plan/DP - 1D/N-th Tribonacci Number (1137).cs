public class Solution
{
    public int Tribonacci(int n) => n switch
    {
        0 => 0,
        1 => 1,
        _ => CalcTribonacciNumber(n)
    };

    private static int CalcTribonacciNumber(int n)
    {
        var firstNumber = 0;
        var secondNumber = 1;
        var thirdNumber = 1;

        for (var i = 2; i < n; i++)
        {
            var newNumber = firstNumber + secondNumber + thirdNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = newNumber;
        }

        return thirdNumber;
    }
}