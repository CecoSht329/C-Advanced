using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car car = new Car();

            car.Make = "Audi";
            car.Model = "A80";
            car.Year = 1992;
            Console.WriteLine($"Make: {car.Make}" +
                $"{Environment.NewLine}Model: {car.Model}" +
                $"{Environment.NewLine}Year: {car.Year}");
        }
    }
}
