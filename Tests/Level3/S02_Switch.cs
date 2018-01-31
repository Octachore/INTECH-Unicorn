using ITI.Unicorn.Core.Level3;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level3
{
    public class S02_Switch
    {
        [TestCase(new[] { 0, 1, 2 }, 3, new[] { 1, 0, 2 })]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5 }, 42, new[] { 0, 2, 4, 5, 3, 1 })]
        [TestCase(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1000000, new[] { 2, 7, 8, 3, 9, 1, 5, 4, 6, 0 })]
        [Timeout(1000)]
        public void P02_Switch_GetNthPermutation(int[] numbers, int n, int[] expected)
        {
            var result = P02_Switch.GetNthPermutation(numbers, n);

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
