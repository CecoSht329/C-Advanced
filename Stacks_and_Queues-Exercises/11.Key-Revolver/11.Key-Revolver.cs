using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int pricePerBullet = int.Parse(Console.ReadLine());
        int magazineSize = int.Parse(Console.ReadLine());
        int[] bulletsAndSize = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();
        int[] locksAndTheirSize = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .Reverse()
            .ToArray();
        int valueOfInteligence = int.Parse(Console.ReadLine());

        Stack<int> bulletsValue = new Stack<int>(bulletsAndSize);
        Stack<int> locksValue = new Stack<int>(locksAndTheirSize);

        int count = 0;
        int bulletCount = bulletsValue.Count();
        while (bulletsValue.Any() && locksValue.Any())
        {
            int bullet = bulletsValue.Pop();
            int @lock = locksValue.Pop();

            if (bullet > @lock)
            {
                Console.WriteLine("Ping!");
                locksValue.Push(@lock);
            }
            else
            {
                Console.WriteLine("Bang!");
            }
            count++;

            if (count == magazineSize && bulletsValue.Any())
            {
                Console.WriteLine("Reloading!");
                count = 0;
            }
        }
        if (bulletsValue.Any() || !bulletsValue.Any() && !locksValue.Any())
        {
            int leftMoney = valueOfInteligence - (bulletCount - bulletsValue.Count) * pricePerBullet;
            Console.WriteLine($"{bulletsValue.Count} bullets left. Earned ${leftMoney}");
        }
        else if (locksValue.Any())
        {
            Console.WriteLine($"Couldn't get through. Locks left: {locksValue.Count}");
        }
    }
}

