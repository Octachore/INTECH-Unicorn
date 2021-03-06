﻿using FluentAssertions;
using ITI.Unicorn.Core.Level1;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level1
{
    public class S05_LotOfNumbersSequel
    {
        private int[,] Matrix1 { get; } =
        {
            {08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08},
            {49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00},
            {81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65},
            {52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91},
            {22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80},
            {24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50},
            {32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70},
            {67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21},
            {24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72},
            {21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95},
            {78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92},
            {16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57},
            {86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58},
            {19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40},
            {04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66},
            {88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69},
            {04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36},
            {20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16},
            {20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54},
            {01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48}
        };


        private int[,] Matrix2 { get; } =
        {
            {63, 81, 06, 34, 15, 71, 22, 53, 70, 35, 79, 67, 12, 67, 82, 48, 13, 47, 02},
            {19, 13, 33, 08, 49, 26, 11, 51, 11, 86, 15, 16, 18, 63, 23, 61, 88, 02, 19},
            {35, 06, 69, 16, 77, 84, 00, 37, 08, 28, 89, 89, 07, 25, 99, 45, 90, 74, 83},
            {32, 47, 34, 10, 86, 11, 87, 55, 31, 56, 46, 25, 11, 44, 08, 45, 42, 44, 06},
            {43, 09, 92, 39, 75, 34, 78, 21, 37, 49, 51, 78, 60, 81, 77, 29, 49, 75, 81},
            {89, 28, 64, 39, 33, 86, 42, 78, 26, 05, 14, 91, 15, 27, 25, 10, 64, 67, 03},
            {27, 40, 16, 53, 07, 46, 42, 58, 66, 69, 99, 35, 11, 65, 35, 47, 30, 96, 68},
            {97, 67, 11, 59, 46, 82, 90, 18, 16, 55, 55, 48, 55, 32, 69, 62, 65, 28, 69},
            {20, 91, 92, 79, 16, 05, 58, 70, 39, 84, 03, 24, 97, 28, 88, 15, 90, 66, 51},
            {15, 63, 19, 94, 08, 46, 00, 27, 18, 08, 68, 43, 27, 37, 80, 44, 38, 09, 77},
            {99, 47, 79, 98, 68, 73, 31, 83, 14, 57, 44, 78, 57, 23, 43, 74, 04, 64, 70},
            {92, 50, 42, 84, 66, 80, 25, 30, 04, 82, 51, 78, 64, 41, 14, 50, 24, 47, 76},
            {15, 53, 27, 84, 49, 36, 40, 22, 35, 05, 83, 29, 19, 30, 43, 51, 73, 87, 47},
            {33, 42, 27, 82, 62, 78, 74, 90, 52, 03, 47, 65, 33, 51, 39, 77, 44, 24, 91},
            {31, 70, 47, 52, 83, 41, 34, 99, 45, 73, 00, 70, 93, 60, 96, 85, 15, 47, 27},
            {50, 50, 00, 51, 28, 92, 29, 68, 71, 98, 28, 51, 09, 70, 59, 15, 67, 73, 11},
            {35, 58, 43, 71, 00, 14, 56, 13, 55, 86, 44, 64, 89, 95, 31, 46, 28, 23, 61},
            {31, 84, 46, 30, 89, 42, 01, 12, 85, 42, 50, 82, 59, 92, 27, 34, 68, 16, 65},
            {78, 37, 31, 79, 13, 73, 23, 31, 06, 74, 05, 40, 74, 51, 02, 77, 50, 05, 32},
            {12, 81, 65, 82, 94, 62, 65, 70, 27, 03, 44, 59, 72, 63, 12, 90, 20, 78, 59}
        };

        private int[,] Matrix3 { get; } =
        {
            {35, 58, 43, 71, 00, 14, 56, 13, 55, 86, 44, 64, 89, 47, 95, 31, 46, 28, 23, 61},
            {78, 37, 31, 79, 13, 73, 23, 31, 06, 74, 05, 40, 74, 19, 51, 02, 77, 50, 05, 32},
            {63, 81, 06, 34, 15, 71, 22, 53, 70, 35, 79, 67, 12, 43, 67, 82, 48, 13, 47, 02},
            {35, 06, 69, 16, 77, 84, 00, 37, 08, 28, 89, 89, 07, 94, 25, 99, 45, 90, 74, 83},
            {43, 09, 92, 39, 75, 34, 78, 21, 37, 49, 51, 78, 60, 65, 81, 77, 29, 49, 75, 81},
            {89, 28, 64, 39, 33, 86, 42, 78, 26, 05, 14, 91, 15, 73, 27, 25, 10, 64, 67, 03},
            {27, 40, 16, 53, 07, 46, 42, 58, 66, 69, 99, 35, 11, 28, 65, 35, 47, 30, 96, 68},
            {97, 67, 11, 59, 46, 82, 90, 18, 16, 55, 55, 48, 55, 71, 32, 69, 62, 65, 28, 69},
            {20, 91, 92, 79, 16, 05, 58, 70, 39, 84, 03, 24, 97, 63, 28, 88, 15, 90, 66, 51},
            {15, 63, 19, 94, 08, 46, 00, 27, 18, 08, 68, 43, 27, 37, 37, 80, 44, 38, 09, 77},
            {19, 13, 33, 08, 49, 26, 11, 51, 11, 86, 15, 16, 18, 89, 63, 23, 61, 88, 02, 19},
            {99, 47, 79, 98, 68, 73, 31, 83, 14, 57, 44, 78, 57, 66, 23, 43, 74, 04, 64, 70},
            {92, 50, 42, 84, 06, 80, 25, 30, 04, 82, 51, 78, 64, 99, 41, 14, 50, 24, 47, 76},
            {15, 53, 27, 84, 49, 36, 40, 22, 35, 05, 83, 29, 19, 57, 30, 43, 51, 73, 87, 47},
            {31, 70, 47, 52, 83, 41, 34, 99, 45, 73, 00, 70, 93, 78, 60, 96, 85, 15, 47, 27},
            {32, 47, 34, 10, 86, 11, 87, 55, 31, 56, 46, 25, 11, 72, 44, 08, 45, 42, 44, 06},
            {50, 50, 00, 51, 28, 92, 29, 68, 71, 98, 28, 51, 09, 54, 70, 59, 15, 67, 73, 11},
            {31, 84, 46, 30, 89, 42, 01, 12, 85, 42, 50, 82, 59, 97, 92, 27, 34, 68, 16, 65},
            {12, 81, 65, 82, 94, 62, 65, 70, 27, 03, 44, 59, 72, 54, 63, 12, 90, 20, 78, 59}
        };

        [Test]
        [Timeout(100)]
        public void P05_LotOfNumbersSequel_GetProduct()
        {
            var result1 = P05_LotOfNumbersSequel.GetProduct(Matrix1);
            var result2 = P05_LotOfNumbersSequel.GetProduct(Matrix2);
            var result3 = P05_LotOfNumbersSequel.GetProduct(Matrix3);

            result1.Should().Be(70600674);
            result2.Should().Be(64999872);
            result3.Should().Be(70523244);
        }
    }
}
