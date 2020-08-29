using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

}
public class Program
{
    public static void Main()
    {
        int totalPeople = int.Parse(Console.ReadLine());

        var people = new List<Person>();

        for (int i = 0; i < totalPeople; i++)
        {
            var currentPerson = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            var person = new Person
            {
                Name = currentPerson[0],
                Age = int.Parse(currentPerson[1])
            };
            people.Add(person);
        }

        string condition = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        Func<Person, bool> filterPredicate;
        if (condition == "older")
        {
            filterPredicate = p => p.Age >= age;
        }
        else
        {
            filterPredicate = p => p.Age < age;
        }

        string format = Console.ReadLine();

        Func<Person, string> printFunc;
        if (format == "name age")
        {
            printFunc = p => $"{p.Name} - {p.Age}";
        }
        else if (format == "name")
        {
            printFunc = p => $"{p.Name}";
        }
        else
        {
            printFunc = p => $"{p.Age}";
        }
        people
            .Where(filterPredicate)
            .Select(printFunc)
            .ToList()
            .ForEach(Console.WriteLine);
    }
}

