using FluentAssertions;
using ITI.Unicorn.Core.Level2;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level2
{
    public class S02_TheBigOne
    {
        [TestCase(10, 9)]
        [TestCase(100, 97)]
        [TestCase(1000, 871)]
        [TestCase(10000, 6171)]
        [TestCase(100000, 77031)]
        [Timeout(500)]
        public void P02_TheBigOne_GetBestStartingNumber(int maxStartingNumber, int expected)
        {
            var result = P02_TheBigOne.GetBestStartingNumber(maxStartingNumber);

            result.Should().Be(expected);
        }
    }
}
