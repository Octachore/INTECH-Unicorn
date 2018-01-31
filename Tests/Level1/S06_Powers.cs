using FluentAssertions;
using ITI.Unicorn.Core.Level1;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level1
{
    public class S06_Powers
    {
        [TestCase(3, 1301)]
        [TestCase(4, 19316)]
        [TestCase(5, 443839)]
        [TestCase(6, 548834)]
        public void P06_Powers_GetSolution(int p, int expected)
        {
            var result = P06_Powers.GetSolution(p);

            result.Should().Be(expected);
        }
    }
}
