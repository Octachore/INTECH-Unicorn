using System;
using System.Linq;

namespace ITI.Unicorn.Core.Level2
{
    public static class P03_Kheops
    {
        public static int GetBiggestPath(int[][] pyramid)
        {
            for (int i = pyramid.Length - 1; i > 0; i--)
            {
                var newPyramid = pyramid.Take(i).ToArray();
                newPyramid[newPyramid.Length - 1] = Combine(pyramid[i - 1], pyramid[i]);
                pyramid = newPyramid;
            }

            return pyramid[0][0];
        }

        private static int[] Combine(int[] upperRow, int[] lowerRow)
        {
            int l = upperRow.Length;
            int[] combined = (int[])upperRow.Clone();
            for (int i = 0; i < l; i++)
            {
                if (combined[i] == 0) continue;
                combined[i] += Math.Max(lowerRow[i], lowerRow[i + 1]);
            }
            return combined;
        }
    }
}
