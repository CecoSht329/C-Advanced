using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int rows = dimentions[0];
        int cols = dimentions[1];
        char[,] matrix = new char[rows, cols];

        ReadMatrixFromConsole(rows, cols, matrix);

        int counter = 0;//counts how many submatrixes we have got
        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {

                if ((matrix[row, col] == matrix[row, col + 1]) &&
                    (matrix[row, col] == matrix[row + 1, col])&&
                    (matrix[row, col]== matrix[row + 1, col + 1]))
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }

    private static void ReadMatrixFromConsole(int rows, int cols, char[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            char[] currentRow = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }
    }
}

