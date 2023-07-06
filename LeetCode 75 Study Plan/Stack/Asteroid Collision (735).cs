public class Solution 
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();
        stack.Push(asteroids[^1]);

        for (var i = asteroids.Length - 2; i >= 0; i--)
        {
            var currentAsteroid = asteroids[i];
            var shouldPushCurrent = true;

            while (stack.Count > 0 && currentAsteroid > 0 && stack.Peek() < 0)
            {
                var previousAsteroid = stack.Pop();

                var currentAsteroidAbsValue = Math.Abs(currentAsteroid);
                var previousAsteroidAbsValue = Math.Abs(previousAsteroid);

                if (currentAsteroidAbsValue <= previousAsteroidAbsValue)
                {
                    if (previousAsteroidAbsValue > currentAsteroidAbsValue)
                    {
                        stack.Push(previousAsteroid);
                    }

                    shouldPushCurrent = false;
                    break;
                }
            }

            if (shouldPushCurrent)
            {
                stack.Push(currentAsteroid);
            }
        }
        
        return stack.ToArray();
    }
}