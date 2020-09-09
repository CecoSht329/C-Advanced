using System;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];


            int beeRow = 0;
            int beeCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (currentRow[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            bool isLost = false;
            int polinatedFlowers = 0;
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "up")
                {
                    matrix[beeRow, beeCol] = '.';
                    if (beeRow - 1 >= 0)
                    {
                        beeRow--;
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            polinatedFlowers++;
                        }
                        if (matrix[beeRow, beeCol] == 'O')
                        {
                            matrix[beeRow, beeCol] = '.';
                            if (beeRow - 1 >= 0)
                            {
                                beeRow--;
                                if (matrix[beeRow, beeCol] == 'f')
                                {
                                    polinatedFlowers++;
                                }
                            }
                            else
                            {
                                isLost = true;
                                break;
                            }
                        }
                        matrix[beeRow, beeCol] = 'B';
                    }
                    else
                    {
                        isLost = true;
                        break;
                    }
                }
                else if (command == "down")
                {
                    matrix[beeRow, beeCol] = '.';
                    if (beeRow + 1 < matrix.GetLength(0))
                    {
                        beeRow++;
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            polinatedFlowers++;
                        }
                        if (matrix[beeRow, beeCol] == 'O')
                        {
                            matrix[beeRow, beeCol] = '.';
                            if (beeRow + 1 < matrix.GetLength(0))
                            {
                                beeRow++;
                                if (matrix[beeRow, beeCol] == 'f')
                                {
                                    polinatedFlowers++;
                                }
                            }
                            else
                            {
                                isLost = true;
                                break;
                            }
                        }
                        matrix[beeRow, beeCol] = 'B';
                    }
                    else
                    {
                        isLost = true;
                        break;
                    }
                }
                else if (command == "left")
                {
                    matrix[beeRow, beeCol] = '.';
                    if (beeCol - 1 >= 0)
                    {
                        beeCol--;
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            polinatedFlowers++;
                        }
                        if (matrix[beeRow, beeCol] == 'O')
                        {
                            matrix[beeRow, beeCol] = '.';
                            if (beeCol - 1 >= 0)
                            {
                                beeCol--;
                                if (matrix[beeRow, beeCol] == 'f')
                                {
                                    polinatedFlowers++;
                                }
                            }
                            else
                            {
                                isLost = true;
                                break;
                            }
                        }
                        matrix[beeRow, beeCol] = 'B';
                    }
                    else
                    {
                        isLost = true;
                        break;
                    }
                }
                else if (command == "right")
                {
                    matrix[beeRow, beeCol] = '.';
                    if (beeCol + 1 < matrix.GetLength(1))
                    {
                        beeCol++;
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            polinatedFlowers++;
                        }
                        if (matrix[beeRow, beeCol] == 'O')
                        {
                            matrix[beeRow, beeCol] = '.';
                            if (beeCol + 1 < matrix.GetLength(1))
                            {
                                beeCol++;
                                if (matrix[beeRow, beeCol] == 'f')
                                {
                                    polinatedFlowers++;
                                }
                            }
                            else
                            {
                                isLost = true;
                                break;
                            }
                        }
                        matrix[beeRow, beeCol] = 'B';
                    }
                    else
                    {
                        isLost = true;
                        break;
                    }
                }
            }
            if (isLost)
            {
                Console.WriteLine("The bee got lost!");
            }
            if (polinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {polinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - polinatedFlowers} flowers more");
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
    }
}
