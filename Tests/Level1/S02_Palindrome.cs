using System.Numerics;
using ITI.Unicorn.Core.Level1;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level1
{
    public class S02_Palindrome
    {
        [Test]
        public void P02_Palindrome_GetNines_WithNegativeCount_ThrowException()
        {
            Assert.That(() => P02_Palindrome.GetNines(-1), Throws.ArgumentException);
        }

        [TestCase(0, 0)]
        [TestCase(1, 9)]
        [TestCase(2, 99)]
        [TestCase(3, 999)]
        [TestCase(4, 9999)]
        [TestCase(10, 9999999999)]
        public void P02_Palindrome_GetNines(int count, long expected)
        {
            var result = P02_Palindrome.GetNines(count);

            Assert.That(result, Is.EqualTo(new BigInteger(expected)));
        }

        [TestCase(0, 0)]
        [TestCase(1, 9)]
        [TestCase(2, 9009)]
        [TestCase(3, 906609)]
        public void P02_Palindrome_GetLargestPalindrome(int factorsDigitsCount, int expected)
        {
            var result = P02_Palindrome.GetLargestPalindrome(factorsDigitsCount);

            Assert.That(result, Is.EqualTo(new BigInteger(expected)));
        }
    }
}
