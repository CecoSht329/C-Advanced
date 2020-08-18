using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

        var stack = new Stack<int>(numbers);

        string input;
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = tokens[0];
            if (command.ToLower() == "add")
            {
                int firstNumber = 0;
                int secondNumber = 0;
                bool successFirstNum = int.TryParse(tokens[1], out firstNumber);
                bool successSecondNum = int.TryParse(tokens[2], out secondNumber);
                if (successFirstNum && successSecondNum)
                {
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
            }
            else if (command.ToLower() == "remove")
            {
                int number = 0;
                bool success = int.TryParse(tokens[1], out number);
                if (success && number <= stack.Count)
                {
                    while (number > 0)
                    {
                        stack.Pop();
                        number--;
                    }
                }
            }
        }
        Console.WriteLine($"Sum: {stack.ToArray().Sum()}");
    }
}

