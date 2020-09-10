using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> data;

        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            this.data = new List<Present>();
        }

        public string Color { get; set; }
        public int Capacity { get; set; }

        public int Count { get => data.Count; }
        public void Add(Present present)
        {
            if (this.data.Count < Capacity)
            {
                data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            if (data.Any(p => p.Name == name))
            {
                data.Remove(data
                    .Where(p => p.Name == name)
                    .FirstOrDefault());
                return true;
            }
            return false;
        }

        public Present GetHeaviestPresent()
        {
            return data.OrderByDescending(p => p.Weight).FirstOrDefault();
        }

        public Present GetPresent(string name)
        {
            return data.Where(p => p.Name == name).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} bag contains:");
            for (int i = 0; i < data.Count - 1; i++)
            {
                sb.AppendLine($"{data[i]}");
            }
            sb.Append($"{data[data.Count - 1]}");
            return sb.ToString();
        }
    }
}
