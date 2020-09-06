namespace CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                //"{model} {power} {displacement} {efficiency}"
                var engineArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine engine = null;

                string model = engineArgs[0];
                int power = int.Parse(engineArgs[1]);
                if (engineArgs.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (engineArgs.Length == 4)
                {
                    int displacement = int.Parse(engineArgs[2]);
                    string efficiency = engineArgs[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }
                else
                {
                    bool isDisplacement = int.TryParse(engineArgs[2], out int displacement);
                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, engineArgs[2]);
                    }
                }
                engines.Add(engine);
            }

            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                var carArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var model = carArgs[0];
                var engineModel = carArgs[1];

                Engine engine = engines
                    .Where(e => e.Model == engineModel)
                    .FirstOrDefault();
                Car car = null;
                if (carArgs.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (carArgs.Length == 4)
                {
                    double weight = double.Parse(carArgs[2]);
                    string color = carArgs[3];
                    car = new Car(model, engine, weight, color);
                }
                else
                {
                    bool isWeight = double.TryParse(carArgs[2], out double weight);
                    if (isWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine, carArgs[2]);
                    }
                }
                cars.Add(car);
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}
