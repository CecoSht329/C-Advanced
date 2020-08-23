using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] dimentions = ParseArrayFromConsole();

        int rows = dimentions[0];
        int cols = dimentions[1];
        int[,] matrix = new int[rows, cols];

        ReadMatrixFromConsole(matrix, rows, cols);

        int[,] maxSquareMatrix = new int[3, 3];

        if (rows >= 3 && cols >= 3)
        {
            int maxSum = int.MinValue;
            for (int row = 0; row < rows - 2; row++)
            {
                int currentSum = 0;
                for (int col = 0; col < cols - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        int line = row;
                        for (int maxRow = 0; maxRow < 3; maxRow++)
                        {
                            int[] currentRow = new int[] { matrix[line, col], matrix[line, col + 1], matrix[line, col + 2] };
                            for (int maxCol = 0; maxCol < 3; maxCol++)
                            {
                                maxSquareMatrix[maxRow, maxCol] = currentRow[maxCol];
                            }
                            line++;
                        }
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(maxSquareMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    static int[] ParseArrayFromConsole() => Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    static void ReadMatrixFromConsole(int[,] matrix, int rows, int cols)
    {
        for (int row = 0; row < rows; row++)
        {
            int[] currentRow = ParseArrayFromConsole();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }
    }
}

