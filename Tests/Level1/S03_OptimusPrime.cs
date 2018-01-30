using ITI.Unicorn.Core.Level1;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level1
{
    public class S03_OptimusPrime
    {
        [TestCase(-5, false)]
        [TestCase(-3, false)]
        [TestCase(-1, false)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(7, true)]
        [TestCase(9, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(12, false)]
        public void P03_OptimusPrime_IsPrime(int num, bool expected)
        {
            var result = P03_OptimusPrime.IsPrime(num);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(2,3)]
        [TestCase(3,5)]
        [TestCase(5,7)]
        [TestCase(773, 787)]
        [TestCase(1049, 1051)]
        [TestCase(4523, 4547)]
        public void P03_OptimusPrime_NextPrime(int prime, int expected)
        {
            var result = P03_OptimusPrime.NextPrime(prime);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 5)]
        [TestCase(4, 7)]
        [TestCase(42, 181)]
        [TestCase(146, 839)]
        [TestCase(310, 2053)]
        [TestCase(1001, 7927)]
        [TestCase(1001, 7927)]
        [TestCase(10001, 104743)]
        [Timeout(100)]
        public void P03_OptimusPrime_GetPrime(int number, int expected)
        {
            var result = P03_OptimusPrime.GetPrime(number);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
