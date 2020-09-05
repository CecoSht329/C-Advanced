using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {
                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} 
                //{tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age}
                //{tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
                var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = carInfo[0];

                var engineSpeed = long.Parse(carInfo[1]);
                var enginePower = long.Parse(carInfo[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                var cargoWeight = long.Parse(carInfo[3]);
                var cargoType = carInfo[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                List<Tire> tires = new List<Tire>();
                for (int tire = 5; tire < carInfo.Length; tire += 2)
                {
                    var tirePressure = double.Parse(carInfo[tire]);
                    var tireAge = long.Parse(carInfo[tire + 1]);
                    Tire currentTire = new Tire(tirePressure, tireAge);
                    tires.Add(currentTire);
                }

                Car currentCar = new Car(model, engine, cargo, tires);
                cars.Add(currentCar);
            }
            string commandType = Console.ReadLine();
            if (commandType == "fragile")
            {
                foreach (Car car in cars
                    .Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t => t.TirePressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }

            }
            else if (commandType == "flamable")
            {
                foreach (Car car in cars
                    .Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
                
            }
        }
    }
}
