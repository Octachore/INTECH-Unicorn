using ITI.Unicorn.Core.Level2;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level2
{
    public class S04_Powers
    {
        [TestCase(3, 1301)]
        [TestCase(4, 19316)]
        [TestCase(5, 443839)]
        [TestCase(6, 548834)]
        public void P04_Powers_GetSolution(int p, int expected)
        {
            var result = P04_Powers.GetSolution(p);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
