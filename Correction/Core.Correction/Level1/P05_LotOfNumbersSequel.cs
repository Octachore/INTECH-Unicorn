using System.Linq;

namespace ITI.Unicorn.Core.Level1
{
    public static class P05_LotOfNumbersSequel
    {
        public static int GetProduct(int[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);

            int max = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    int vertical = 0;
                    int horizontal = 0;
                    int diagUp = 0;
                    int diagDown = 0;

                    if (i <= rowsCount - 4) vertical = matrix[i, j] * matrix[i + 1, j] * matrix[i + 2, j] * matrix[i + 3, j];
                    if (j <= colsCount - 4) horizontal = matrix[i, j] * matrix[i, j + 1] * matrix[i, j + 2] * matrix[i, j + 3];
                    if (i >= 3 && j <= colsCount - 4) diagUp = matrix[i, j] * matrix[i - 1, j + 1] * matrix[i - 2, j + 2] * matrix[i - 3, j + 3];
                    if (i <= rowsCount - 4 && j <= colsCount - 4) diagDown = matrix[i, j] * matrix[i + 1, j + 1] * matrix[i + 2, j + 2] * matrix[i + 3, j + 3];

                    max = new[] { max, vertical, horizontal, diagUp, diagDown }.Max();
                }
            }

            return max;
        }
    }
}
