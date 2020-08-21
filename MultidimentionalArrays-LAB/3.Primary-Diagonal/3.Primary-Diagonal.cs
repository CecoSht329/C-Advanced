using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int numberOfRowsAndCols = int.Parse(Console.ReadLine());

        int rows = numberOfRowsAndCols;
        int cols = numberOfRowsAndCols;

        //int[,] matrix = new int[rows, cols];
        int sumOfPrimaryDiagonal = 0;
        for (int row = 0; row < rows; row++)
        {
            int[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            sumOfPrimaryDiagonal += currentRow[row];
        }
        Console.WriteLine(sumOfPrimaryDiagonal);
    }
}

