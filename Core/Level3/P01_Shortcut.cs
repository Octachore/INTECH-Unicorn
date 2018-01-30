using System.Collections.Generic;
using System.Numerics;

namespace ITI.Unicorn.Core.Level3
{
    public class P01_Shortcut
    {
        // Combinatorics solution (shortcut)
        public static BigInteger GetNumberOfPaths(int a, int b)
        {
            return BinomialCoefficient(a + b, a);
        }

        // Iterative solution
        public static BigInteger GetNumberOfPathsIterative(int a, int b)
        {
            BigInteger[,] grid = new BigInteger[a + 1, b + 1];
            for (int i = 0; i <= a; i++)
            {
                grid[i, 0] = 1;
            }

            for (int j = 0; j <= b; j++)
            {
                grid[0, j] = 1;
            }

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
                }
            }

            return grid[a, b];
        }

        private static BigInteger Factorial(int n)
        {
            if (n >= 2) return n * Factorial(n - 1);
            return 1;
        }

        private static BigInteger BinomialCoefficient(int n, int k) => Factorial(n) / (Factorial(k) * Factorial(n - k));
    }
}
