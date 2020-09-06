namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        private const string DefaultValueString = "n/a";
        private const int DefaultValueInt = -1;
        public Car(string model, Engine engine, double weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public Car(string model, Engine engine, double weight)
            : this(model, engine, weight, DefaultValueString)
        {
        }
        public Car(string model, Engine engine, string color)
          : this(model, engine, DefaultValueInt, color)
        {
        }
        public Car(string model, Engine engine)
          : this(model, engine, DefaultValueInt, DefaultValueString)
        {
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"{Engine}");
            if (Weight == -1)
            {
                sb.AppendLine($"  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {Weight}");
            }
            sb.Append($"  Color: {Color}");

            return sb.ToString();
        }
    }
}
