using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.data = new List<Rabbit>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get => this.data.Count; }
        public void Add(Rabbit rabbit)
        {
            if (this.data.Count < Capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            if (this.data.Any(r => r.Name == name))
            {
                this.data.Remove(this.data.Where(r => r.Name == name).FirstOrDefault());
                return true;
            }
            return false;
        }

        public void RemoveSpecies(string species)
        {
            this.data = this.data.Where(r => r.Species != species).ToList();
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbitToSell = this.data.Where(r => r.Name == name).FirstOrDefault();
            rabbitToSell.Available = false;
            return rabbitToSell;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> rabbitsToSell = new List<Rabbit>();
            foreach (Rabbit rabbit in this.data
                .Where(r => r.Species == species))
            {
                rabbit.Available = false;
                rabbitsToSell.Add(rabbit);
            }
            return rabbitsToSell.ToArray();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {Name}:");
            for (int i = 0; i < this.data.Where(r => r.Available == true).Count() - 1; i++)
            {
                sb.AppendLine($"{data[i]}");
            }
            sb.Append($"{data[data.Count - 1]}");

            return sb.ToString();
        }
    }
}
