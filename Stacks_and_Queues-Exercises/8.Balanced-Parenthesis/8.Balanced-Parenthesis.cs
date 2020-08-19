using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        Stack<char> openParentheses = new Stack<char>();

        bool isBalanced = true;
        foreach (char symbol in expression)
        {
            if (symbol == '(' || symbol == '[' || symbol == '{')
            {
                openParentheses.Push(symbol);
            }
            else
            {
                if (!openParentheses.Any())
                {
                    isBalanced = false;
                    break;
                }

                char currentOpenBracket = openParentheses.Pop();

                bool isRoundBalanced = currentOpenBracket == '(' && symbol == ')';
                bool isCurlyBalanced = currentOpenBracket == '{' && symbol == '}';
                bool isSquareBalanced = currentOpenBracket == '[' && symbol == ']';

                if (!isRoundBalanced && !isCurlyBalanced && !isSquareBalanced)
                {
                    isBalanced = false;
                    break;
                }
            }
        }
        if (isBalanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

