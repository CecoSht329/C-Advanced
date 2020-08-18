using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> stack = new Stack<char>(input);
        char[] reversed = stack.ToArray();
        Console.WriteLine(string.Join("", reversed));
        //char symbol;
        //while (stack.TryPop(out symbol) == true)
        //{
        //    Console.Write(symbol);
        //}
        //Stack<char> stack = new Stack<char>();

        //for (int i = 0; i < input.Length; i++)
        //{
        //    stack.Push(input[i]);
        //}
        //while (stack.Count > 0)
        //{
        //    Console.Write(stack.Pop());
        //}
    }
}

