using System.Numerics;
using ITI.Unicorn.Core.Level1;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level1
{
    public class S02_NoLemonNoMelon
    {
        [Test]
        public void P02_NoLemonNoMelon_GetNines_WithNegativeCount_ThrowException()
        {
            Assert.That(() => P02_NoLemonNoMelon.GetNines(-1), Throws.ArgumentException);
        }

        [TestCase(0, 0)]
        [TestCase(1, 9)]
        [TestCase(2, 99)]
        [TestCase(3, 999)]
        [TestCase(4, 9999)]
        [TestCase(10, 9999999999)]
        public void P02_NoLemonNoMelon_GetNines(int count, long expected)
        {
            var result = P02_NoLemonNoMelon.GetNines(count);

            Assert.That(result, Is.EqualTo(new BigInteger(expected)));
        }

        [TestCase(0, 0)]
        [TestCase(1, 9)]
        [TestCase(2, 9009)]
        [TestCase(3, 906609)]
        [Timeout(500)]
        public void P02_NoLemonNoMelon_GetLargestPalindrome(int factorsDigitsCount, int expected)
        {
            var result = P02_NoLemonNoMelon.GetLargestPalindrome(factorsDigitsCount);

            Assert.That(result, Is.EqualTo(new BigInteger(expected)));
        }
    }
}
