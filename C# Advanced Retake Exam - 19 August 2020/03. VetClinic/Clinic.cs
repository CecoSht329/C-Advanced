using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new List<Pet>();
        }

        public int Capacity { get; set; }

        public int Count
        {
            get => this.data.Count();
        }

        public void Add(Pet pet)
        {
            if (this.data.Count < Capacity)
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            if (this.data.Any(p => p.Name == name))
            {
                this.data.Remove(this.data.Where(p => p.Name == name).FirstOrDefault());
                return true;
            }
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            if (this.data.Any(p => p.Name == name && p.Owner == owner))
            {
                return this.data.Where(p => p.Name == name && p.Owner == owner).First();
            }
            return null;
        }

        public Pet GetOldestPet()
        {
            Pet oldestPet = this.data.OrderByDescending(p => p.Age).FirstOrDefault();
            return oldestPet;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            for (int pet = 0; pet < this.data.Count - 1; pet++)
            {
                sb.AppendLine($"Pet {this.data[pet].Name} with owner: {this.data[pet].Owner}");
            }
            sb.Append($"Pet {this.data[this.data.Count - 1].Name} with owner: {this.data[this.data.Count - 1].Owner}");
            return sb.ToString();
        }
    }
}
