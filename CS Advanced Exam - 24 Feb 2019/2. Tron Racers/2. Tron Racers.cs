using System;

namespace _2._Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            int firstRow = 0;
            int firstCol = 0;

            int secondRow = 0;
            int secondCol = 0;

            InitializeMatrix(matrix, ref firstRow, ref firstCol, ref secondRow, ref secondCol);

            while (true)
            {

                var commandPair = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string commandForFirstPlayer = commandPair[0];
                string commandForSecondPlayer = commandPair[1];

                if (commandForFirstPlayer == "up")
                {
                    firstRow--;
                    if (firstRow < 0)
                    {
                        firstRow = matrix.GetLength(0) - 1;
                    }
                }
                else if (commandForFirstPlayer == "down")
                {
                    firstRow++;
                    if (firstRow == matrix.GetLength(0))
                    {
                        firstRow = 0;
                    }
                }
                else if (commandForFirstPlayer == "left")
                {
                    firstCol--;
                    if (firstCol < 0)
                    {
                        firstCol = matrix.GetLength(1) - 1;
                    }
                }
                else if (commandForFirstPlayer == "right")
                {

                    firstCol++;
                    if (firstCol == matrix.GetLength(1))
                    {
                        firstCol = 0;
                    }
                }

                if (matrix[firstRow, firstCol] == 's')
                {
                    matrix[firstRow, firstCol] = 'x';
                    break;
                }
                else
                {
                    matrix[firstRow, firstCol] = 'f';
                }

                if (commandForSecondPlayer == "up")
                {
                    secondRow--;
                    if (secondRow < 0)
                    {
                        secondRow = matrix.GetLength(0) - 1;
                    }
                }
                else if (commandForSecondPlayer == "down")
                {
                    secondRow++;
                    if (secondRow == matrix.GetLength(0))
                    {
                        secondRow = 0;
                    }
                }
                else if (commandForSecondPlayer == "left")
                {
                    secondCol--;
                    if (secondCol < 0)
                    {
                        secondCol = matrix.GetLength(1) - 1;
                    }
                }
                else if (commandForSecondPlayer == "right")
                {
                    secondCol++;
                    if (secondCol == matrix.GetLength(1))
                    {
                        secondCol = 0;
                    }
                }

                if (matrix[secondRow, secondCol] == 'f')
                {
                    matrix[secondRow, secondCol] = 'x';
                    break;
                }
                else
                {
                    matrix[secondRow, secondCol] = 's';
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void InitializeMatrix(char[,] matrix, ref int firstRow, ref int firstCol, ref int secondRow, ref int secondCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'f')//first player position
                    {
                        firstRow = row;
                        firstCol = col;
                    }
                    else if (matrix[row, col] == 's')//second player position
                    {
                        secondRow = row;
                        secondCol = col;
                    }
                }
            }
        }
    }
}
