using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }
    }
}
