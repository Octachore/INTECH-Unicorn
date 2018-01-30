using System.Numerics;
using ITI.Unicorn.Core.Level2;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level2
{
    public class S01_Rabbits
    {
        [TestCase(42, 44)]
        [TestCase(100, 188)]
        [TestCase(15146, 14328)]
        [TestCase(4000000, 4613732)]
        [Timeout(500)]
        public void P01_Rabbits_SumEvenFibonacciTerms(int maxTerm, long expected)
        {
            var result = P01_Rabbits.SumEvenFibonacciTerms(maxTerm);

            Assert.That(result, Is.EqualTo(new BigInteger(expected)));
        }
    }
}
