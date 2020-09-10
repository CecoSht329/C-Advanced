using System;

namespace _02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int turnsCount = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            int playerRow = 0;
            int playerCol = 0;
            InitializeMatrix(matrix, ref playerRow, ref playerCol);

            bool playerWon = false;
            for (int i = 0; i < turnsCount; i++)
            {
                string movement = Console.ReadLine();
                matrix[playerRow, playerCol] = '-';
                if (movement == "down")
                {
                    playerRow = MoveDown(matrix, playerRow, playerCol);
                }
                else if (movement == "up")
                {
                    playerRow = MoveUp(matrix, playerRow, playerCol);
                }
                else if (movement == "left")
                {
                    playerCol = MoveLeft(matrix, playerRow, playerCol);

                }
                else if (movement == "right")
                {
                    playerCol = MoveRight(matrix, playerRow, playerCol);
                }

                if (matrix[playerRow, playerCol] == '-')
                {
                    matrix[playerRow, playerCol] = 'f';
                }

                if (matrix[playerRow, playerCol] == 'F')
                {
                    matrix[playerRow, playerCol] = 'f';
                    playerWon = true;
                    break;
                }
            }
            if (playerWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
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

        private static int MoveRight(char[,] matrix, int playerRow, int playerCol)
        {
            if (playerCol + 1 < matrix.GetLength(1))
            {
                playerCol++;
            }
            else
            {
                playerCol = 0;
            }
            if (matrix[playerRow, playerCol] == 'B')
            {
                if (playerCol + 1 < matrix.GetLength(1))
                {
                    playerCol++;
                }
                else
                {
                    playerCol = 0;
                }
            }
            else if (matrix[playerRow, playerCol] == 'T')
            {
                if (playerCol - 1 >= 0)
                {
                    playerCol--;
                }
                else
                {
                    playerCol = matrix.GetLength(1) - 1;
                }
            }

            return playerCol;
        }

        private static int MoveLeft(char[,] matrix, int playerRow, int playerCol)
        {
            if (playerCol - 1 >= 0)
            {
                playerCol--;
            }
            else
            {
                playerCol = matrix.GetLength(1) - 1;
            }
            if (matrix[playerRow, playerCol] == 'B')
            {
                if (playerCol - 1 >= 0)
                {
                    playerCol--;
                }
                else
                {
                    playerCol = matrix.GetLength(1) - 1;
                }
            }
            else if (matrix[playerRow, playerCol] == 'T')
            {
                if (playerCol + 1 < matrix.GetLength(1))
                {
                    playerCol++;
                }
                else
                {
                    playerCol = 0;
                }
            }

            return playerCol;
        }

        private static int MoveUp(char[,] matrix, int playerRow, int playerCol)
        {
            if (playerRow - 1 >= 0)
            {
                playerRow--;
            }
            else
            {
                playerRow = matrix.GetLength(0) - 1;
            }
            if (matrix[playerRow, playerCol] == 'B')
            {
                if (playerRow - 1 >= 0)
                {
                    playerRow--;
                }
                else
                {
                    playerRow = matrix.GetLength(0) - 1;
                }
            }
            else if (matrix[playerRow, playerCol] == 'T')
            {
                if (playerRow + 1 < matrix.GetLength(0))
                {
                    playerRow++;
                }
                else
                {
                    playerRow = 0;
                }
            }

            return playerRow;
        }

        private static int MoveDown(char[,] matrix, int playerRow, int playerCol)
        {
            if (playerRow + 1 < matrix.GetLength(0))
            {
                playerRow++;
            }
            else
            {
                playerRow = 0;
            }
            if (matrix[playerRow, playerCol] == 'B')
            {
                if (playerRow + 1 < matrix.GetLength(0))
                {
                    playerRow++;
                }
                else
                {
                    playerRow = 0;
                }
            }
            else if (matrix[playerRow, playerCol] == 'T')
            {
                if (playerRow - 1 >= 0)
                {
                    playerRow--;
                }
                else
                {
                    playerRow = matrix.GetLength(1) - 1;
                }
            }

            return playerRow;
        }

        private static void InitializeMatrix(char[,] matrix, ref int playerRow, ref int playerCol)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'f')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
