using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string token = Console.ReadLine();
        Queue<string> cars = new Queue<string>();
        int counter = 0;

        while (token.ToLower() != "end")
        {
            if (token.ToLower() != "green")
            {
                cars.Enqueue(token);
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    string car;
                    if (cars.TryDequeue(out car))
                    {
                        Console.WriteLine($"{car} passed!");
                        counter++;
                    }
                }
            }
            token = Console.ReadLine();
        }
        Console.WriteLine($"{counter} cars passed the crossroads.");
    }
}

