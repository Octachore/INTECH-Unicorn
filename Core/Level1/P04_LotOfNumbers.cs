using System.Linq;
using System.Numerics;

namespace ITI.Unicorn.Core.Level1
{
    public static class P04_LotOfNumbers
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

        //public static BigInteger GetAdjacentProduct2(string number, int count)
        //{
        //    BigInteger bigestProd = 0;

        //    for (int i = 0; i < (number.Length - count); i++)
        //    {
        //        BigInteger prod = ProdResult(number, count, i);

        //        if (prod > bigestProd)
        //        {
        //            bigestProd = prod;
        //        }
        //    }

        //    return bigestProd;
        //}

        //public static BigInteger ProdResult(string number, int count, int position)
        //{
        //    BigInteger currentPro = 1;

        //    for (int i = position; i < (position + count); i++)
        //    {
        //        currentPro *= Convert.ToInt32(number[i].ToString());
        //    }

        //    return currentPro;
        //}
    }
}
