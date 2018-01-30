using System.Collections.Generic;

namespace ITI.Unicorn.Core.Level2
{
    public class P02_TheBigOne
    {
        private static Dictionary<long, List<long>> _alreadyChecked;

        public static int GetBestStartingNumber(int maxStartingNumber)
        {
            _alreadyChecked = new Dictionary<long, List<long>>();

            int bestStart = 1;
            int longest = 1;

            for (int i = 1; i <= maxStartingNumber; i++)
            {
                var sequence = CollatzSequence(i);
                if (sequence.Count <= longest) continue;
                longest = sequence.Count;
                bestStart = i;
            }

            return bestStart;
        }

        private static List<long> CollatzSequence(int n)
        {
            var sequence = new List<long> { n };

            long num = n;

            while (num > 1)
            {
                num = NextCollatz(num);
                if (_alreadyChecked.ContainsKey(num))
                {
                    sequence.AddRange(_alreadyChecked[num]);
                    break;
                }
                sequence.Add(num);
            }

            _alreadyChecked.Add(n, sequence);

            return sequence;
        }

        private static long NextCollatz(long n)
        {
            if (n % 2 == 0) return n / 2;
            return 3 * n + 1;
        }
    }
}
