using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(double tirePressure, long tireAge)
        {
            TirePressure = tirePressure;
            TireAge = tireAge;
        }

        //{tirePressure} {tireAge} 
        public double TirePressure { get; set; }
        public long TireAge { get; set; }
    }
}
