using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Family family = new Family();

            int pepoleCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < pepoleCount; i++)
            {
                string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person currentPerson = new Person(name, age);
                family.AddMember(currentPerson);
            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
