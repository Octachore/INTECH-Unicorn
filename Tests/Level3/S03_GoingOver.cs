using ITI.Unicorn.Core.Level3;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level3
{
    public class S03_GoingOver
    {
        [TestCase(new[] { 1, 3, 2, 3, 1 }, 2)]
        [TestCase(new[] { 2147483647, 2147483647, 2147483647, 2147483647, 2147483647, 2147483647 }, 0)]
        [TestCase(new[] { 2566, 5469, 1898, 127, 2441, 4612, 2554, 5269, 2785, 5093, 3931, 2532, 1195, 1101, 1334, 2124, 1156, 3400, 747, 5046, 3325, 4039 }, 62)]
        public void P04_GoingOver_GetSolution(int[] array, int expected)
        {
            var result = P03_GoingOver.GetSolution(array);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
