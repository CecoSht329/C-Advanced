using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];

        int snakeRow = 0;
        int snakeCol = 0;
        int counter = 0;
        int firstBrow = 0;
        int firstBcol = 0;
        int secondBrow = 0;
        int secondBcol = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char[] currentRow = Console.ReadLine().ToCharArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = currentRow[col];
                if (currentRow[col] == 'S')
                {
                    snakeRow = row;
                    snakeCol = col;
                }
                if (currentRow[col] == 'B')
                {
                    counter++;
                    if (counter == 1)
                    {
                        firstBrow = row;
                        firstBcol = col;
                    }
                    else
                    {
                        secondBrow = row;
                        secondBcol = col;
                    }
                }
            }
        }

        bool snakeIsOut = false;
        //char prevoisSnakePosition = matrix[snakeRow, snakeCol];
        int foodEaten = 0;
        while (true)
        {
            string command = Console.ReadLine();

            if (command == "up")
            {
                matrix[snakeRow, snakeCol] = '.';
                if (snakeRow - 1 >= 0)
                {
                    snakeRow--;
                    if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodEaten++;
                    }
                    else if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        snakeRow = secondBrow;
                        snakeCol = secondBcol;
                    }
                }
                else
                {
                    snakeIsOut = true;
                    break;
                }
            }
            else if (command == "down")
            {
                matrix[snakeRow, snakeCol] = '.';
                if (snakeRow + 1 < matrix.GetLength(0))
                {
                    snakeRow++;
                    if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodEaten++;
                    }
                    else if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        snakeRow = secondBrow;
                        snakeCol = secondBcol;
                    }
                }
                else
                {
                    snakeIsOut = true;
                    break;
                }
            }
            else if (command == "left")
            {
                matrix[snakeRow, snakeCol] = '.';
                if (snakeCol - 1 >= 0)
                {
                    snakeCol--;
                    if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodEaten++;
                    }
                    else if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        snakeRow = secondBrow;
                        snakeCol = secondBcol;
                    }
                }
                else
                {
                    snakeIsOut = true;
                    break;
                }
            }
            else if (command == "right")
            {
                matrix[snakeRow, snakeCol] = '.';
                if (snakeCol + 1 < matrix.GetLength(1))
                {
                    snakeCol++;
                    if (matrix[snakeRow, snakeCol] == '*')
                    {
                        foodEaten++;
                    }
                    else if (matrix[snakeRow, snakeCol] == 'B')
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        snakeRow = secondBrow;
                        snakeCol = secondBcol;
                    }
                }
                else
                {
                    snakeIsOut = true;
                    break;
                }
            }
            matrix[snakeRow, snakeCol] = 'S';
            if (foodEaten >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
                break;
            }
        }
        if (snakeIsOut)
        {
            Console.WriteLine("Game over!");
        }
        Console.WriteLine($"Food eaten: {foodEaten}");

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col]);
            }
            Console.WriteLine();
        }
    }
}

