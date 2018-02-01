using System.Collections.Generic;

namespace ITI.Unicorn.Core.Level1
{
    public static class P08_WeakLink
    {
        public static int GetResult(int initialValue)
        {
            var chain = new List<int> { initialValue };

            int current = initialValue;

            while (true)
            {
                current = NextNumber(current);
                if (chain.Contains(current))
                {
                    return chain.Count + 1;
                }
                chain.Add(current);
            }
        }

        private static int NextNumber(int input)
        {
            int retVal = 0;

            while (input > 0)
            {
                int digit = input % 10;
                retVal += digit * digit;
                input /= 10;
            }
            return retVal;
        }
    }
}
