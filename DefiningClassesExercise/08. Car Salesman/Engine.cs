namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine
    {
        private const string DefaultValueString = "n/a";
        private const int DefaultValueInt = -1;
        public Engine(string model, int power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement)
            : this(model, power, displacement, DefaultValueString)
        {

        }
        public Engine(string model, int power, string efficiency)
            : this(model, power, DefaultValueInt, efficiency)
        {
        }

        public Engine(string model, int power)
           : this(model, power, DefaultValueInt, DefaultValueString)
        {
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"  {Model}:");
            sb.AppendLine($"    Power: {Power}");
            if (Displacement == -1)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {Displacement}");
            }

            sb.Append($"    Efficiency: {Efficiency}");

            return sb.ToString();
        }
    }
}
