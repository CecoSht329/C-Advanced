using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace _5.Applied_Arithmetics
{
    class Program
    {
        static void Main()
        {
            Func<List<int>, List<int>> addFunc = x => x.Select(a => a += 1).ToList();
            Func<List<int>, List<int>> subtractFunc = x => x.Select(a => a -= 1).ToList();
            Func<List<int>, List<int>> multiplyFunc = x => x.Select(a => a *= 2).ToList();
            Action<List<int>> printList = x => Console.WriteLine(string.Join(" ", x));

            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = addFunc(numbers);
                        break;
                    case "subtract":
                        numbers = subtractFunc(numbers);
                        break;
                    case "multiply":
                        numbers = multiplyFunc(numbers);
                        break;
                    case "print":
                        printList(numbers);
                        break;
                }
            }

        }
    }
}
