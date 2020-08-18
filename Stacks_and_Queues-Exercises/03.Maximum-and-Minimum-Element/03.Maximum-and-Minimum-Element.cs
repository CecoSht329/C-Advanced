using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int queries = int.Parse(Console.ReadLine());

        Stack<int> stackOfNums = new Stack<int>();

        for (int i = 0; i < queries; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (input.StartsWith("1"))
            {
                int element = int.Parse(tokens[1]);
                stackOfNums.Push(element);
            }
            else if (input.StartsWith("2"))
            {
                if (stackOfNums.Count > 0)
                {
                    stackOfNums.Pop();
                }
            }
            else if (input.StartsWith("3"))
            {
                int maxElement = int.MinValue;
                foreach (int number in stackOfNums)
                {
                    if (number > maxElement)
                    {
                        maxElement = number;
                    }
                }
                Console.WriteLine(maxElement);
            }
            else if (input.StartsWith("4"))
            {
                int minElement = int.MaxValue;
                foreach (int number in stackOfNums)
                {
                    if (number < minElement)
                    {
                        minElement = number;
                    }
                }
                Console.WriteLine(minElement);
            }
        }
        Console.WriteLine(string.Join(", ", stackOfNums));
    }
}

