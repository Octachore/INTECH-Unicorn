using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ITI.Unicorn.Core.Level2
{
    public static class P01_Rabbits
    {
        public static BigInteger SumEvenFibonacciTerms(int maxTerm)
        {
            return Fibonacci(maxTerm).Where(i => i % 2 == 0).Aggregate(BigInteger.Zero, (a, b) => a + b);
        }

        private static IEnumerable<BigInteger> Fibonacci(BigInteger max)
        {
            yield return 1;
            yield return 1;

            BigInteger a = 1;
            BigInteger b = 1;
            while (true)
            {
                BigInteger sum = a + b;
                yield return sum;
                if (sum > max) break;
                a = b;
                b = sum;
            }
        }
    }
}
