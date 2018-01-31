using System;
using System.Collections.Generic;
using System.Linq;

namespace ITI.Unicorn.Core.Level1
{
    public static class P03_OptimusPrime
    {
        public static int GetPrime(int n)
        {
            Guard.StrictlyPositive(n, nameof(n));

            if (n == 1) return 2;

            var primes = new List<int> { 2 };
            while (primes.Count != n)
            {
                primes.Add(NextPrime(primes.Last()));
            }
            return primes.Last();
        }

        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            if (num == 3) return true;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        public static int NextPrime(int prime)
        {
            if (prime == 2) return 3;
            if (prime % 2 == 0) prime++;

            do
            {
                prime += 2;
            } while (!IsPrime(prime));

            return prime;
        }
    }
}
