using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int rowsAndCols = int.Parse(Console.ReadLine());
        int rows = rowsAndCols;
        int cols = rowsAndCols;

        char[,] matrix = new char[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            string currentRow = Console.ReadLine();
            char[] currentRowToArray = currentRow.ToCharArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currentRowToArray[col];
            }
        }

        char symbolToSearchFor = char.Parse(Console.ReadLine());

        int[] coordinates = new int[2];
        bool isFound = false;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                char currentSymbol = matrix[row, col];
                if (symbolToSearchFor == currentSymbol)
                {
                    coordinates[0] = row;
                    coordinates[1] = col;
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"({string.Join(", ", coordinates)})");
                break;
            }
        }
        if (!isFound)
        {
            Console.WriteLine($"{symbolToSearchFor} does not occur in the matrix");
        }
    }
}

