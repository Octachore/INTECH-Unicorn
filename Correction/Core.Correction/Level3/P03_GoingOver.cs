using System.Linq;

namespace ITI.Unicorn.Core.Level3
{
    public static class P03_GoingOver
    {
        private static int _count;

        public static int GetSolution(int[] array)
        {
            // Idea : perform a merge sort of the array, and increment a count in the merge function for each pair maching the condition
            _count = 0;
            MergeSort(array);
            return _count;
        }

        private static int[] MergeSort(int[] array)
        {
            int n = array.Length;

            if (n <= 1) return array;

            var a = array.Take(n / 2).ToArray();
            var b = array.Skip(n / 2).ToArray();

            return Merge(MergeSort(a), MergeSort(b));
        }

        private static int[] Merge(int[] a, int[] b)
        {
            if (a.Length == 0) return b;
            if (b.Length == 0) return a;

            if (a[0] < b[0])
            {
                _count += b.Count(i => a[0] > 2.0 * i);
                var head = a.Take(1);
                var tail = Merge(a.Skip(1).ToArray(), b);
                return head.Concat(tail).ToArray();
            }
            else
            {
                _count += a.Count(i => i > 2.0 * b[0]);
                var head = b.Take(1);
                var tail = Merge(a, b.Skip(1).ToArray());
                return head.Concat(tail).ToArray();
            }
        }
    }
}
