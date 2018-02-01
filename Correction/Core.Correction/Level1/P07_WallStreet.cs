using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Unicorn.Core.Level1
{
    public static class P07_WallStreet
    {
        public static int GetResult(int[] marketPrices)
        {
            int maxprofit = 0;
            for (int i = 0; i < marketPrices.Length - 1; i++)
            {
                for (int j = i + 1; j < marketPrices.Length; j++)
                {
                    int profit = marketPrices[j] - marketPrices[i];
                    if (profit > maxprofit)
                    {
                        maxprofit = profit;
                    }
                }
            }
            return maxprofit;
        }
    }
}
