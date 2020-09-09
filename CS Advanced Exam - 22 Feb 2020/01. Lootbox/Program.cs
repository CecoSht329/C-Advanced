using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var input2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> lootBoxOne = new Queue<int>(input1);
            Stack<int> lootBoxTwo = new Stack<int>(input2);
            int claimedItems = 0;

            while (true)
            {
                if (lootBoxOne.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                if (lootBoxTwo.Count == 0)
                {
                    Console.WriteLine($"Second lootbox is empty");
                    break;
                }
                int currentFirstBoxLoot = lootBoxOne.Peek();
                int currentSecondBoxLoot = lootBoxTwo.Peek();
                if ((currentFirstBoxLoot + currentSecondBoxLoot) % 2 != 0)
                {
                    input1.Add(lootBoxTwo.Pop());
                    lootBoxOne = new Queue<int>(input1);
                }
                else
                {
                    int sum = lootBoxOne.Dequeue() + lootBoxTwo.Pop();
                    claimedItems += sum;
                    input1 = new List<int>(lootBoxOne);
                }
            }
            if (claimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
    }
}
