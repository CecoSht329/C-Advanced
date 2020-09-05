using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            int pepoleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < pepoleCount; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person currentPerson = new Person(name, age);
                people.Add(currentPerson);
            }
            Console.WriteLine();
            foreach (Person person in people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
