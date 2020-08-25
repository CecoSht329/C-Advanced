using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var carNumbers = new HashSet<string>();
        var input = "";
        while ((input = Console.ReadLine()).ToLower() != "end")
        {
            var tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var direction = tokens[0];
            var liscencePlate = tokens[1];

            if (direction.ToLower() == "in")
            {
                carNumbers.Add(liscencePlate);
            }
            else if (direction.ToLower() == "out")
            {
                if (carNumbers.Contains(liscencePlate))
                {
                    carNumbers.Remove(liscencePlate);
                }
            }
        }
        if (carNumbers.Count > 0)
        {
            Console.WriteLine(string.Join(Environment.NewLine, carNumbers));
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}

