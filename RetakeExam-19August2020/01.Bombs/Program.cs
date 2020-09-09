using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var input1 = Console.ReadLine()
             .Split(", ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
        var input2 = Console.ReadLine()
             .Split(", ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

        Queue<int> bombEffects = new Queue<int>(input1);
        Stack<int> bombCasings = new Stack<int>(input2);

        Dictionary<int, string> bombTypes = new Dictionary<int, string>
        {
            {40, "Datura Bombs"},
            {60, "Cherry Bombs"},
            {120, "Smoke Decoy Bombs"}
        };

        Dictionary<string, int> bombsCount = new Dictionary<string, int>
        {
             {"Datura Bombs", 0},
            {"Cherry Bombs", 0},
            {"Smoke Decoy Bombs", 0}
        };
        bool bombPouchFull = false;
        while (bombEffects.Count() > 0 && bombCasings.Count() > 0)
        {
            int sum = bombEffects.Peek() + bombCasings.Peek();
            if (bombTypes.ContainsKey(sum))
            {
                bombsCount[bombTypes[sum]]++;
                bombEffects.Dequeue();
                bombCasings.Pop();
            }
            else
            {
                int currentBombCasing = bombCasings.Pop() - 5;
                bombCasings.Push(currentBombCasing);
            }

            if (bombsCount["Datura Bombs"] >= 3
                && bombsCount["Cherry Bombs"] >= 3
                && bombsCount["Smoke Decoy Bombs"] >= 3)
            {
                bombPouchFull = true;
                break;
            }
        }
        if (bombPouchFull == true)
        {
            Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
        }
        else
        {
            Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
        }

        if (!bombEffects.Any())
        {
            Console.WriteLine("Bomb Effects: empty");
        }
        else
        {
            Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
        }

        if (!bombCasings.Any())
        {
            Console.WriteLine("Bomb Casings: empty");
        }
        else
        {
            Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
        }

        foreach (var bomb in bombsCount.OrderBy(b => b.Key))
        {
            Console.WriteLine($"{bomb.Key}: {bomb.Value}");
        }
    }
}

