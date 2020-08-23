using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();
        string snake = Console.ReadLine();

        int rows = dimentions[0];
        int cols = dimentions[1];
        char[,] matrix = new char[rows, cols];

        int counter = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = snake[counter];
                counter++;
                if (counter == snake.Length)
                {
                    counter = 0;
                }
            }
        }
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
            }
            else
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    Console.Write(matrix[row, col]);
                }
            }
            Console.WriteLine();
        }
    }
}

