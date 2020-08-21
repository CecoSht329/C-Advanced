using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int[][] array = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            int[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            array[row] = currentRow;
        }

        string input = "";
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = tokens[0];
            int row = int.Parse(tokens[1]);
            int col = int.Parse(tokens[2]);
            int value = int.Parse(tokens[3]);

            if (row < 0
                || row >= rows
                || col < 0
                || col >= array[row].Length)
            {
                Console.WriteLine("Invalid coordinates");
                continue;
            }

            if (command == "Add")
            {
                array[row][col] += value;
            }
            else if (command == "Subtract")
            {
                array[row][col] -= value;
            }
        }
        foreach (int[] currentRow in array)
        {
            Console.WriteLine(string.Join(" ", currentRow));
        }
    }
}

