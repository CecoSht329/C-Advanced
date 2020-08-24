using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        //input
        int fieldSize = int.Parse(Console.ReadLine());
        string[] directions = Console.ReadLine().Split();
        char[,] field = new char[fieldSize, fieldSize];
        ReadFieldFromConsole(field);
        //step find start point coordinates
        int startRow = 0;
        int startCol = 0;
        for (int row = 0; row < field.GetLength(0); row++)
        {
            var currentRow = new List<char>();
            for (int col = 0; col < field.GetLength(1); col++)
            {
                currentRow.Add(field[row, col]);
            }
            if (currentRow.Contains('s'))
            {
                startRow = row;
                startCol = currentRow.IndexOf('s');
            }
        }
        //step 3
        // * – a regular position on the field.
        //e – the end of the route.
        //c - coal
        //s - the place where the miner starts
        int totalCoal = 0;
        foreach (var item in field)
        {
            if (item == 'c')
            {
                totalCoal++;
            }
        }
        int directionsCount = directions.Length;
        foreach (string direction in directions)
        {
            directionsCount--;
            switch (direction)
            {
                case "up":
                    if (startRow - 1 >= 0)
                    {
                        startRow--;
                    }
                    break;
                case "down":
                    if (startRow + 1 < field.GetLength(0))
                    {
                        startRow++;
                    }
                    break;
                case "left":
                    if (startCol - 1 >= 0)
                    {
                        startCol--;
                    }
                    break;
                case "right":
                    if (startCol + 1 < field.GetLength(1))
                    {
                        startCol++;
                    }
                    break;
            }
            char currentChar = field[startRow, startCol];
            if (currentChar == 'e')
            {
                Console.WriteLine($"Game over! ({startRow}, {startCol})");
                break;
            }
            if (currentChar == 'c')
            {
                field[startRow, startCol] = '*';
                totalCoal--;
            }
            if (totalCoal == 0)
            {
                Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                break;
            }
            if (directionsCount == 0)
            {
                Console.WriteLine($"{totalCoal} coals left. ({startRow}, {startCol})");
            }
        }
    }

    private static void ReadFieldFromConsole(char[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            char[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            for (int col = 0; col < field.GetLength(1); col++)
            {
                field[row, col] = currentRow[col];
            }
        }
    }
}

