using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Unicorn.Core.Level1
{
    public class P04_LotOfNumbers
    {
        public static BigInteger GetAdjacentProduct(string number, int bufferSize)
        {
            BigInteger bigestProd = 0;

            for (int cursor = 0; cursor <= number.Length - bufferSize; cursor++)
            {
                BigInteger prod = number
                    .Substring(cursor, bufferSize)
                    .Select(i => BigInteger.Parse($"{i}"))
                    .Aggregate(BigInteger.One, (acc, i) => acc * i);

                if (prod > bigestProd) bigestProd = prod;
            }

            return bigestProd;
        }
    }
}
