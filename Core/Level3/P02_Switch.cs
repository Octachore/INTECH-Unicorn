using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ITI.Unicorn.Core.Level3
{
    public static class P02_Switch
    {
        /*
         * === BRAIN SANDBOX (what I wrote on a notepad before starting coding) ===
         *
         * There are n! permutations (=> bruteforce is a bad idea)
         *
         * Imagine we have the numbers 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 to permute and we want permutation N° 1 000 000
         *
         * It means there are 9! permutations if we remove the 0 (i.e. the 9! first permutations starts with 0)
         * In the same way, there are 9! permutations starting with each other digit.
         *
         * OK, then we now that 2*9! = 725 760 and 3*9! = 1 088 640.
         * We want N° 1 000 000. With the previous results, we know it starts with 2 (permutations starting with 2 are between the 2 previous values).
         *
         * I think the process can be repeated.
         * We now have our first digit (2). There are 8! sub-permutations starting with 0, 8! starting with 1...
         * We find that 2*9! + 6*8! = 967680 and that 2*9! + 7*8! = 1 008 000
         * So the sub-permutation following the 2 starts with the 6th remaining digit (all except 2, because it's already used), i.e. 7
         * We now have 27 as the first 2 gigits or out 1 000 000th permutation.
         *
         * We repeat the process...
         *
         * Now I have to code that :)
         */

        public static int[] GetNthPermutation(int[] numbers, int n)
        {
            Guard.StrictlyPositive(n, nameof(n));

            List<int> availableNumbers = new List<int>(numbers);
            int[] permutation = new int[numbers.Length];
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < availableNumbers.Count; j++)
                {
                    if (count + (j + 1) * Factorial(numbers.Length - i - 1) >= n)
                    {
                        count += j * (int)Factorial(numbers.Length - i - 1);
                        permutation[i] = availableNumbers.GetAndRemoveAt(j);
                        break;
                    }
                }
            }

            return permutation;
        }

        private static T GetAndRemoveAt<T>(this IList<T> list, int index)
        {
            var value = list[index];
            list.RemoveAt(index);
            return value;
        }

        private static BigInteger Factorial(int n)
        {
            if (n >= 2) return n * Factorial(n - 1);
            return 1;
        }

        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
