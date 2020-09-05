using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            var carCollection = new List<Car>();

            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {
                //"{model} {fuelAmount} {fuelConsumptionFor1km}"
                var carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = carInfo[0];
                var fuelAmount = double.Parse(carInfo[1]);
                var fuelConsumptionFor1km = double.Parse(carInfo[2]);
                var currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
                carCollection.Add(currentCar);
            }

            var input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                //"Drive {carModel} {amountOfKm}"
                var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var carModel = tokens[1];
                var distanceToTravel = double.Parse(tokens[2]);

                Car currentCar = carCollection
                    .Where(c => c.Model == carModel)
                    .FirstOrDefault();
                currentCar.Drive(distanceToTravel);
            }
            foreach (var car in carCollection)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
