using System.Linq;
using System.Numerics;

namespace ITI.Unicorn.Core.Level1
{
    public class P04_LotOfNumbers
    {
        public static BigInteger GetAdjacentProduct(string number, int count)
        {
            BigInteger bigestProd = 0;

            for (int cursor = 0; cursor <= number.Length - count; cursor++)
            {
                BigInteger prod = number
                    .Substring(cursor, count)
                    .Select(i => BigInteger.Parse($"{i}"))
                    .Aggregate(BigInteger.One, (acc, i) => acc * i);

                if (prod > bigestProd) bigestProd = prod;
            }

            return bigestProd;
        }
    }
}
