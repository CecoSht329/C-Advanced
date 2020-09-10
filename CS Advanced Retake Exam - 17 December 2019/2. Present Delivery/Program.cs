using System;
using System.Linq;

namespace _2._Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presentsCount = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            int santaRow = 0;
            int santaCol = 0;
            int niceKids = 0;
            InitializeMatrix(matrix, ref santaRow, ref santaCol, ref niceKids);

            int happyNiceKids = 0;
            string instruction = "";
            while ((instruction = Console.ReadLine()) != "Christmas morning")
            {
                matrix[santaRow, santaCol] = '-';
                switch (instruction)
                {
                    case "up":
                        santaRow--;
                        break;
                    case "down":
                        santaRow++;
                        break;
                    case "left":
                        santaCol--;
                        break;
                    case "right":
                        santaCol++;
                        break;
                }
                if (matrix[santaRow, santaCol] == 'V')
                {
                    happyNiceKids++;
                    presentsCount--;
                }
                else if (matrix[santaRow, santaCol] == 'C')
                {
                    if (matrix[santaRow - 1, santaCol] == 'V')
                    {
                        happyNiceKids++;
                        presentsCount--;
                    }
                    else if (matrix[santaRow - 1, santaCol] == 'X')
                    {
                        presentsCount--;
                    }
                    matrix[santaRow - 1, santaCol] = '-';
                    if (matrix[santaRow + 1, santaCol] == 'V')
                    {
                        happyNiceKids++;
                        presentsCount--;
                    }
                    else if (matrix[santaRow + 1, santaCol] == 'X')
                    {
                        presentsCount--;
                    }
                    matrix[santaRow + 1, santaCol] = '-';
                    if (matrix[santaRow, santaCol - 1] == 'V')
                    {
                        happyNiceKids++;
                        presentsCount--;
                    }
                    else if (matrix[santaRow, santaCol - 1] == 'X')
                    {
                        presentsCount--;
                    }
                    matrix[santaRow, santaCol - 1] = '-';
                    if (matrix[santaRow, santaCol + 1] == 'V')
                    {
                        happyNiceKids++;
                        presentsCount--;
                    }
                    else if (matrix[santaRow, santaCol + 1] == 'X')
                    {
                        presentsCount--;
                    }
                    matrix[santaRow, santaCol + 1] = '-';
                }
                matrix[santaRow, santaCol] = 'S';
                if (presentsCount <= 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            if (happyNiceKids >= niceKids)
            {
                Console.WriteLine($"Good job, Santa! {happyNiceKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKids - happyNiceKids} nice kid/s.");
            }
        }

        private static void InitializeMatrix(char[,] matrix, ref int santaRow, ref int santaCol, ref int niceKids)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (currentRow[col] == 'S')
                    {
                        santaRow = row;
                        santaCol = col;
                    }
                    if (matrix[row, col] == 'V')
                    {
                        niceKids++;
                    }
                }
            }
        }
    }
}
