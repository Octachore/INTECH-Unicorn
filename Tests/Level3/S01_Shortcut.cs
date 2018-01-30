using System.Numerics;
using ITI.Unicorn.Core.Level3;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level3
{
    public class S01_Shortcut
    {
        [TestCase(2, 2, 6)]
        [TestCase(4, 4, 70)]
        [TestCase(20, 20, 137846528820)]
        [TestCase(22, 30, 270533919634160)]
        [Timeout(100)]
        public void P01_Shortcut_GetNumberOfPaths(int a, int b, long expected)
        {
            var result1 = P01_Shortcut.GetNumberOfPaths(a, b);
            var result2 = P01_Shortcut.GetNumberOfPathsIterative(a, b);

            Assert.That(result1, Is.EqualTo(new BigInteger(expected)));
            Assert.That(result2, Is.EqualTo(new BigInteger(expected)));
        }
    }
}
