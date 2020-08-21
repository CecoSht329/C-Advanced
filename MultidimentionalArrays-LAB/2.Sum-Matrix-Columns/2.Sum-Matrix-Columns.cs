using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int rows = dimentions[0];
        int cols = dimentions[1];

        int[,] matrix = new int[rows, cols];
        int[] sums = new int[cols];
        for (int row = 0; row < rows; row++)
        {
            int[] currentRow = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
            for (int col = 0; col < cols; col++)
            {
                sums[col] += currentRow[col];
            }
        }
        foreach (int sum in sums)
        {
            Console.WriteLine(sum);
        }
    }
}


