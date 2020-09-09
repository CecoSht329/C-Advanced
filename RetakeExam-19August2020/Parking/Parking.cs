using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            this.data = new List<Car>();
        }


        public string Type { get; set; }
        public int Capacity { get; set; }

        public int Count { get => this.data.Count(); }


        public void Add(Car car)
        {
            if (this.data.Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (this.data.Any(c => c.Manufacturer == manufacturer && c.Model == model))
            {
                this.data.Remove(this.data.Where(c => c.Manufacturer == manufacturer && c.Model == model).FirstOrDefault());
                return true;
            }
            return false;
        }

        public Car GetLatestCar()
        {
            return this.data.OrderByDescending(c => c.Year).FirstOrDefault();
        }

        public Car GetCar(string manufacturer, string model)
        {
            return this.data.Where(c => c.Manufacturer == manufacturer && c.Model == model).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"The cars are parked in {Type}:");
            for (int i = 0; i < this.data.Count - 1; i++)
            {
                stringBuilder.AppendLine($"{this.data[i]}");
            }
            stringBuilder.Append($"{this.data[this.data.Count - 1]}");
            return stringBuilder.ToString();
        }
    }
}
