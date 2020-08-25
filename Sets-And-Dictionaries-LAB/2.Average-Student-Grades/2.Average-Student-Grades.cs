using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

class Program
{
    static void Main()
    {
        var grades = new Dictionary<string, List<decimal>>();

        int studentCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentCount; i++)
        {
            string[] inputInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = inputInfo[0];
            decimal grade = decimal.Parse(inputInfo[1]);

            if (!grades.ContainsKey(name))
            {
                grades.Add(name, new List<decimal>());
            }
            grades[name].Add(grade);
        }

        foreach (var keyValuePair in grades)
        {
            Console.Write($"{keyValuePair.Key} -> ");
            foreach (var item in keyValuePair.Value)
            {
                Console.Write($"{item:F2} ");
            }
            Console.WriteLine($"(avg: {keyValuePair.Value.Average():F2})");
        }
    }
}

