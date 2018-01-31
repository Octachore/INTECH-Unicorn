using FluentAssertions;
using ITI.Unicorn.Core.Level1;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level1
{
    public class S01_Unicornflakes
    {
        [TestCase(new[] { 1, 2, 3, 4, 6, 8, 9, 11, 12, 13 }, new[] { "1", "2", "uni", "4", "uni", "8", "uni", "11", "uni", "13" })]
        [TestCase(new[] { 1, 2, 4, 6, 8, 9 }, new[] { "1", "2", "4", "uni", "8", "uni" })]
        [TestCase(new[] { -6, -4, -3, -1, 1, 3, 4 }, new[] { "uni", "-4", "uni", "-1", "1", "uni", "4" })]
        public void P01_Unicornflakes_Uni(int[] input, string[] expected)
        {
            string[] result = P01_Unicornflakes.GetSolution(input);

            result.ShouldBeEquivalentTo(expected);
        }

        [TestCase(new[] { 1, 2, 4, 5, 8, 10, 11, 13 }, new[] { "1", "2", "4", "corn", "8", "corn", "11", "13" })]
        [TestCase(new[] { 1, 2, 4, 5, 8 }, new[] { "1", "2", "4", "corn", "8" })]
        [TestCase(new[] { -5, -1, 1, 5 }, new[] { "corn", "-1", "1", "corn" })]
        public void P01_Unicornflakes_Corn(int[] input, string[] expected)
        {
            string[] result = P01_Unicornflakes.GetSolution(input);

            result.ShouldBeEquivalentTo(expected);
        }

        [TestCase(new[] { 1, 2, 4, 7, 8, 11, 13, 14 }, new[] { "1", "2", "4", "flakes", "8", "11", "13", "flakes" })]
        [TestCase(new[] { 1, 2, 4, 8, 14 }, new[] { "1", "2", "4", "8", "flakes" })]
        [TestCase(new[] { -7, -1, 1, 7 }, new[] { "flakes", "-1", "1", "flakes" })]
        public void P01_Unicornflakes_flakes(int[] input, string[] expected)
        {
            string[] result = P01_Unicornflakes.GetSolution(input);

            result.ShouldBeEquivalentTo(expected);
        }

        [TestCase(new int[0], new string[0])]
        [TestCase(
            new[] { -105, -35, -21, -15, -7, -5, -3, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 20, 21, 22, 34, 35, 36, 104, 105, 106 },
            new[] { "unicornflakes", "cornflakes", "uniflakes", "unicorn", "flakes", "corn", "uni", "unicornflakes", "1", "2", "uni", "4", "corn", "uni", "flakes", "8", "uni", "corn", "11", "uni", "13", "flakes", "unicorn", "corn", "uniflakes", "22", "34", "cornflakes", "uni", "104", "unicornflakes", "106" }
        )]
        [TestCase(new[] { -7, -5, -3, -1, 1, 3, 5, 7 }, new[] { "flakes", "corn", "uni", "-1", "1", "uni", "corn", "flakes" })]
        public void P01_Unicornflakes_UniCornFlakes(int[] input, string[] expected)
        {
            string[] result = P01_Unicornflakes.GetSolution(input);

            result.ShouldBeEquivalentTo(expected);
        }
    }
}
