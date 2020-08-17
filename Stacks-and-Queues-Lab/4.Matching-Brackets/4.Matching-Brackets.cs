using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputToArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                stack.Push(i);
            }
            else if (input[i] == ')')
            {
                int start = stack.Pop();
                Console.WriteLine(input.Substring(start, i - start + 1));
            }
        }
    }
}

