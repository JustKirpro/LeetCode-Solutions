public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        var lowerBound = 1;
        var upperBound = n;

        while (true)
        {
            var middle = lowerBound + (upperBound - lowerBound) / 2;
            var guessResult = guess(middle);

            if (guessResult == 0)
            {
                return middle;
            }
            
            if (guessResult == -1)
            {
                upperBound = middle - 1;
            }
            else
            {
                lowerBound = middle + 1;
            }
        }
    }
}