using System;
using System.Collections.Generic;
using System.Linq;

namespace ITI.Unicorn.Core.Level2
{
    public static class P04_Powers
    {
        public static int GetSolution(int p)
        {
            /*
             * We need to find the upper limit to test numbers
             * The biggest sum of powers is when all digits are 9 (sum_of_powers = n * 9^p, where n is the number of digits)
             * But if n > p, then 10^n > sum_of_powers
             *
             * Our upper limit is 10^(p+1)
             */

            int result = 0;

            int max = (int)Math.Pow(10, p + 1);

            for (int i = 2; i < max; i++)
            {
                var sumOfPowers = i.ToDigits().Sum(d => (int)Math.Pow(d, p));
                if (sumOfPowers == i) result += i;
            }

            return result;
        }

        private static List<int> ToDigits(this int num)
        {
            var digits = new List<int>();
            while (num > 0)
            {
                digits.Add(num % 10);
                num = num / 10;
            }
            digits.Reverse();
            return digits;
        }
    }
}
