using System;
using System.Diagnostics;

namespace ITI.Unicorn.Core.Level2
{
    public static class P04_Forest
    {
        public static int GetNumberOfChoppedTrees(int[,] forest)
        {
            throw new NotImplementedException();
        }

        public static Square GetStart(int[,] forest)
        {
            throw new NotImplementedException();
        }
    }

    [DebuggerDisplay("({I}:{J}) {Count}")]
    public struct Square
    {
        public int I { get; }
        public int J { get; }
        public int Count { get; }

        public Square(int i, int j, int count)
        {
            I = i;
            J = j;
            Count = count;
        }

        public static bool operator ==(Square a, Square b) => throw new NotImplementedException();
        public static bool operator !=(Square a, Square b) => throw new NotImplementedException();
    }
}
