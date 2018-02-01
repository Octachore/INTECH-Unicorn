using FluentAssertions;
using ITI.Unicorn.Core.Level1;
using ITI.Unicorn.Core.Level2;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level2
{
    public class S04_Forest
    {
        [Test]
        public void P04_Forest_Square_Equality()
        {
            var a = new Square(4, 9, 12);
            var b = new Square(4, 9, 12);
            var c = new Square(3, 8, 11);

            a.Should().Be(b);
            a.Should().NotBe(c);
            (a == b).Should().BeTrue();
            (a == c).Should().BeFalse();
        }

        private int[,] Forest0 { get; } =
        {
            { 0, 2, 3, 4 },
            { 6, 4, 5, 2 },
            { 9, 7, 0, 1 },
            { 3, 2, 4, 5 }
        };

        private int[,] Forest1 { get; } =
        {
            { 5, 7, 8, 6, 3 },
            { 0, 0, 7, 0, 4 },
            { 4, 6, 3, 4, 9 },
            { 3, 1, 0, 5, 8 }
        };

        private int[,] Forest2 { get; } =
        {
            {87, 22, 36, 95, 45, 93, 29},
            {95, 72, 14, 82, 25, 12, 97},
            {50, 14, 37, 43, 69, 60, 83},
            {53, 79, 90, 09, 25, 48, 46},
            {63, 27, 77, 94, 98, 09, 71},
            {61, 61, 63, 72, 09, 89, 73},
            {94, 03, 56, 60, 41, 32, 60},
            {34, 12, 15, 79, 36, 51, 25},
            {52, 12, 15, 37, 55, 37, 25}
        };

        private int[,] Forest3 { get; } =
        {
            {72, 96, 40, 42, 05, 12},
            {75, 94, 69, 27, 60, 32},
            {75, 37, 32, 78, 31, 96},
            {05, 29, 89, 57, 16, 04},
            {73, 05, 79, 30, 39, 41},
            {68, 98, 83, 07, 28, 24},
            {37, 43, 10, 39, 53, 20},
            {74, 65, 79, 09, 61, 52},
            {33, 11, 92, 49, 53, 18}
        };

        [Test]
        public void P04_Forest_GetStart()
        {
            var result0 = P04_Forest.GetStart(Forest0);
            var result1 = P04_Forest.GetStart(Forest1);
            var result2 = P04_Forest.GetStart(Forest2);
            var result3 = P04_Forest.GetStart(Forest3);

            result0.Should().Be(new Square(2, 1, 7));
            result1.Should().Be(new Square(1, 2, 7));
            result2.Should().Be(new Square(4, 3, 94));
            result3.Should().Be(new Square(4, 2, 79));
        }

        [Test]
        public void P04_Forest_GetNumberOfChoppedTrees()
        {
            var result0 = P04_Forest.GetNumberOfChoppedTrees(Forest0);
            var result1 = P04_Forest.GetNumberOfChoppedTrees(Forest1);
            var result2 = P04_Forest.GetNumberOfChoppedTrees(Forest2);
            var result3 = P04_Forest.GetNumberOfChoppedTrees(Forest3);

            result0.Should().Be(55);
            result1.Should().Be(27);
            result2.Should().Be(2065);
            result3.Should().Be(1513);
        }
    }
}
