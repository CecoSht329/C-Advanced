using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] dimentions = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int rows = dimentions[0];
        int cols = dimentions[1];

        var matrix = new string[rows, cols];
        ReadMatrixFromConsole(rows, cols, matrix);

        string input;
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //swap row1 col1 row2c col2
            if (input.StartsWith("swap"))
            {

                if ((tokens.Length > 5 || tokens.Length < 5))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    //2 3
                    //1 2 3
                    //4 5 6
                    //swap 0 0 1 1
                    int row1 = int.Parse(tokens[1]);
                    int col1 = int.Parse(tokens[2]);
                    int row2 = int.Parse(tokens[3]);
                    int col2 = int.Parse(tokens[4]);
                    if ((row1 < 0 || row1 >= rows) ||
                        (col1 < 0 || row2 >= cols) ||
                        (row2 < 0 || row2 >= rows) ||
                        (col2 < 0 || row2 >= cols))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string firstElement = matrix[row1, col1];
                        string temp = firstElement;
                        string secondElement = matrix[row2, col2];
                        matrix[row1, col1] = secondElement;
                        matrix[row2, col2] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }

    private static void ReadMatrixFromConsole(int rows, int cols, string[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            string[] currentRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }
    }
}

