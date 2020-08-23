using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        double[][] jaggedArray = new double[rows][];

        for (int row = 0; row < rows; row++)
        {
            jaggedArray[row] = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
        }
        Analyze(jaggedArray);
        string input = "";
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = tokens[0];
            int targetRow = int.Parse(tokens[1]);
            int targetCol = int.Parse(tokens[2]);
            int value = int.Parse(tokens[3]);

            if (!IsInside(jaggedArray, targetRow, targetCol))
            {
                continue;
            }

            if (command.ToLower() == "add")
            {
                jaggedArray[targetRow][targetCol] += value;
            }
            else if (command.ToLower() == "subtract")
            {
                jaggedArray[targetRow][targetCol] -= value;
            }
        }
        foreach (var row in jaggedArray)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }

    private static bool IsInside(double[][] jaggedArray, int targetRow, int targetCol)
    {
        return targetRow >= 0 && targetRow < jaggedArray.Length
            && targetCol >= 0 && targetCol < jaggedArray[targetRow].Length;
    }

    private static void Analyze(double[][] jaggedArray)
    {
        for (int row = 0; row < jaggedArray.Length - 1; row++)
        {
            if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] *= 2;
                    jaggedArray[row + 1][col] *= 2;
                }
            }
            else
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] /= 2;
                }
                for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                {
                    jaggedArray[row + 1][col] /= 2;
                }
            }
        }
    }
}

