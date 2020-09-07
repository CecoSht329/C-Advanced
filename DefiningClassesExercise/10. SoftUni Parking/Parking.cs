using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public int Count
        {
            get { return cars.Count; }
        }

        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (this.cars.Count >= this.capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            Car carToRemove = cars.Where(c => c.RegistrationNumber == registrationNumber).FirstOrDefault();
            cars.Remove(carToRemove);
            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            Car carToGet = cars.Where(c => c.RegistrationNumber == registrationNumber).FirstOrDefault();
            return carToGet;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var regNumber in registrationNumbers)
            {
                Car carToRemove = cars.Where(x => x.RegistrationNumber == regNumber).FirstOrDefault();
                cars.Remove(carToRemove);
            }
        }
    }
}
