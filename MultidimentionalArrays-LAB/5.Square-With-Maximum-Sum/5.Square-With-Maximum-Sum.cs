using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var dimentions = ParseArrayFromConsole();

        int rows = dimentions[0];
        int cols = dimentions[1];
        var matrix = new int[rows, cols];
        FillMatrixWithValues(matrix);

        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSum = matrix[row, col]
                    + matrix[row, col + 1]
                    + matrix[row + 1, col]
                    + matrix[row + 1, col + 1];
                if (currentSum > maxSum)
                {
                    maxRow = row;
                    maxCol = col;
                    maxSum = currentSum;
                }
            }
        }
        Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
        Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
        Console.WriteLine(maxSum);
    }

    private static void FillMatrixWithValues(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            var currentRow = ParseArrayFromConsole();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }
    }

    static int[] ParseArrayFromConsole()
        => Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

}

