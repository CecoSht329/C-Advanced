using System;


class Program
{
    static void Main()
    {
        long rows = int.Parse(Console.ReadLine());

        long[][] pascalTriangle = new long[rows][];

        if (rows >= 0)
        {
            pascalTriangle[0] = new long[] { 1, };
        }

        if (rows >= 0)
        {
            pascalTriangle[0] = new long[] { 1, 1 };
        }

        for (int row = 0; row < rows; row++)
        {
            pascalTriangle[row] = new long[row + 1];
            pascalTriangle[row][0] = 1;
            for (int col = 1; col < row; col++)
            {
                pascalTriangle[row][col] =
                    pascalTriangle[row - 1][col]
                    + pascalTriangle[row - 1][col - 1];
            }
            pascalTriangle[row][row] = 1;
        }

        foreach (var currentRow in pascalTriangle)
        {
            Console.WriteLine(string.Join(" ", currentRow));
        }
    }
}

