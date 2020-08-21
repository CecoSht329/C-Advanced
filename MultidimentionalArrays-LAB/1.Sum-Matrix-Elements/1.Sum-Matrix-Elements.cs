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

        for (int row = 0; row < rows; row++)
        {
            int[] currentRow = ParseArrayFromConsole();

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }
        long sum = 0;
        foreach (int element in matrix)
        {
            sum += element;
        }
        Console.WriteLine(rows);
        Console.WriteLine(cols);
        Console.WriteLine(sum);
    }

    public static int[] ParseArrayFromConsole()
    {
        return Console.ReadLine()
            .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}

