using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<string> stack = new Stack<string>(input
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Reverse());

        while (stack.Count > 1)
        {
            int operanad1 = int.Parse(stack.Pop());
            string sign = stack.Pop();
            int operand2 = int.Parse(stack.Pop());

            switch (sign)
            {
                case "+":
                    stack.Push((operanad1 + operand2).ToString());
                    break;
                case "-":
                    stack.Push((operanad1 - operand2).ToString());
                    break;
                default:
                    throw new ArgumentException("Unknown operator");
            }
        }
        Console.WriteLine(stack.Pop());
    }
}

