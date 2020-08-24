using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[,] field = new int[fieldSize, fieldSize];

        ReadFieldFromConsole(field);

        string[] coordinatesValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        ExplodeTheBombs(field, coordinatesValues);

        int aliveCells = 0;
        int sumAliveCells = 0;
        foreach (int cell in field)
        {
            if (cell > 0)
            {
                aliveCells++;
                sumAliveCells += cell;
            }
        }
        Console.WriteLine($"Alive cells: {aliveCells}");
        Console.WriteLine($"Sum: {sumAliveCells}");

        PrintField(field);
    }

    private static void PrintField(int[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                Console.Write(field[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    private static void ExplodeTheBombs(int[,] field, string[] coordinatesValues)
    {
        foreach (string rowColPair in coordinatesValues)
        {
            int[] currentBombCoordinates = rowColPair
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int currentBombRow = currentBombCoordinates[0];
            int currentBombCol = currentBombCoordinates[1];
            int currentBomb = field[currentBombRow, currentBombCol];


            for (int row = currentBombRow - 1; row <= currentBombRow + 1; row++)
            {
                bool isBiggerCol = false;
                bool isBiggerRow = false;
                int counter = 0;
                for (int col = currentBombCol - 1; col <= currentBombCol + 1; col++)
                {

                    if (col < 0)
                    {
                        col++;
                    }
                    if (row < 0)
                    {
                        row++;
                    }
                    if (col >= field.GetLength(1))
                    {
                        isBiggerCol = true;
                        col--;
                    }
                    if (row >= field.GetLength(0))
                    {
                        isBiggerRow = true;
                        row--;
                    }
                    if ((counter < field.GetLength(0) - 1 || counter < field.GetLength(1) - 1) 
                        && field[row, col] > 0)
                    {
                        field[row, col] -= currentBomb;
                        counter++;
                    }
                    if (isBiggerCol)
                    {
                        col++;
                    }
                    if (isBiggerRow)
                    {
                        row++;
                    }
                }

            }
        }
    }

    private static void ReadFieldFromConsole(int[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            int[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int col = 0; col < field.GetLength(1); col++)
            {
                field[row, col] = currentRow[col];
            }
        }
    }
}

