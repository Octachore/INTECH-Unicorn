using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ITI.Unicorn.Core.Level2
{
    public static class P04_Forest
    {
        public static int GetNumberOfChoppedTrees(int[,] forest)
        {
            var current = GetStart(forest);

            var visited = new List<Square>();

            while (true)
            {
                visited.Add(current);

                var up = forest.TryGetSquare(current.I, current.J + 1);
                var down = forest.TryGetSquare(current.I, current.J - 1);
                var left = forest.TryGetSquare(current.I - 1, current.J);
                var right = forest.TryGetSquare(current.I + 1, current.J);

                var possibleNexts = new[] { up, down, left, right }
                    .Where(s => s?.Count > 0 && !visited.Contains(s.Value));

                if (!possibleNexts.Any()) break;

                current = possibleNexts.Cast<Square>().Aggregate((a, b) => a.Count > b.Count ? a : b);
            }

            return visited.Sum(s => s.Count);
        }

        public static Square GetStart(int[,] forest)
        {
            int width = forest.GetLength(0);
            int height = forest.GetLength(1);

            var possibleStarts = new[]
            {
                forest.GetSquare(width / 2, height / 2),
                forest.GetSquare((width - 1) / 2, height / 2),
                forest.GetSquare(width / 2, (height - 1) / 2),
                forest.GetSquare((width - 1) / 2, (height - 1) / 2)
            };

            return possibleStarts.Aggregate((a, b) => a.Count > b.Count ? a : b);
        }

        private static Square? TryGetSquare(this int[,] forest, int i, int j)
        {
            if (i < 0 || i >= forest.GetLength(0) || j < 0 || j >= forest.GetLength(1)) return null;
            return forest.GetSquare(i, j);
        }

        private static Square GetSquare(this int[,] forest, int i, int j) => new Square(i, j, forest[i, j]);
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

        public override bool Equals(object obj) => obj is Square && this == (Square)obj;

        public override int GetHashCode() => I.GetHashCode() ^ J.GetHashCode() ^ Count.GetHashCode();

        public static bool operator ==(Square x, Square y) => x.I == y.I && x.J == y.J && x.Count == y.Count;

        public static bool operator !=(Square x, Square y) => !(x == y);
    }
}
