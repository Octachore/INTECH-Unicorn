using System.Linq;
using System.Numerics;

namespace ITI.Unicorn.Core.Level1
{
    public class P02_NoLemonNoMelon
    {
        public static BigInteger GetLargestPalindrome(int factorsDigitsCount)
        {
            Guard.Positive(factorsDigitsCount, nameof(factorsDigitsCount));

            if (factorsDigitsCount == 0) return 0;

            var upper = GetNines(factorsDigitsCount);
            var lower = BigInteger.Pow(10, factorsDigitsCount - 1);
            BigInteger max = 0;
            for (var i = upper; i >= lower; i--)
            {
                for (var j = i; j >= lower; j--)
                {
                    var prod = i * j;
                    if (IsPalindromic(prod) && prod > max)
                    {
                        max = prod;
                    }
                }
            }
            return max;
        }

        public static BigInteger GetNines(int count)
        {
            Guard.Positive(count, nameof(count));

            BigInteger val = 0;
            for (int i = 0; i < count; i++)
            {
                val += 9 * BigInteger.Pow(10, i);
            }
            return val;
        }

        private static bool IsPalindromic(BigInteger num) => $"{num}".SequenceEqual($"{num}".Reverse());
    }
}
