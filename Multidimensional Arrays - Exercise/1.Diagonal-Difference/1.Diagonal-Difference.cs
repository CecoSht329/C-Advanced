using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int rows = n;
        int cols = n;
        int[,] matrix = new int[rows, cols];

        int firstDiagonalSum = 0;
        int counter = 0;
        int secondCounter = n - 1;
        int secondDiagonalSum = 0;
        for (int row = 0; row < rows; row++)
        {
            int[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
               .ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currentRow[col];
            }
            firstDiagonalSum += currentRow[counter];
            counter++;
            secondDiagonalSum += currentRow[secondCounter];
            secondCounter--;
        }
        Console.WriteLine($"{Math.Abs(firstDiagonalSum - secondDiagonalSum)}");
    }
}

