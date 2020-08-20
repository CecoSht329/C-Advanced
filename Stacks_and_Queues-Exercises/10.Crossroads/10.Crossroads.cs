using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int greenLightSeconds = int.Parse(Console.ReadLine());
        int freeWindowSeconds = int.Parse(Console.ReadLine());
        Queue<string> cars = new Queue<string>();

        int originalGreenLightSeconds = greenLightSeconds;
        int originalFreeWindowSeconds = freeWindowSeconds;

        string input = "";
        int totalPassedCars = 0;
        bool crashPresent = false;
        string crashedCar = "";
        int crashedIndex = 0;
        while ((input = Console.ReadLine()) != "END")
        {
            if (input != "green")
            {
                string car = input;
                cars.Enqueue(car);
            }
            else
            {
                greenLightSeconds = originalGreenLightSeconds;
                freeWindowSeconds = originalFreeWindowSeconds;

                int count = cars.Count;
                for (int i = 0; i < count; i++)
                {
                    string currentCar = cars.Peek();
                    if (currentCar.Length <= greenLightSeconds)
                    {
                        greenLightSeconds -= currentCar.Length;
                        cars.Dequeue();
                        totalPassedCars++;
                    }
                    else
                    {
                        if (greenLightSeconds > 0)
                        {
                            int timeLeft = greenLightSeconds + freeWindowSeconds;
                            if (currentCar.Length <= timeLeft)
                            {
                                cars.Dequeue();
                                totalPassedCars++;
                            }
                            else
                            {
                                ;
                                crashPresent = true;
                                crashedCar = currentCar;
                                crashedIndex = timeLeft;
                                break;
                            }
                            greenLightSeconds = 0;
                        }
                    }
                }
                if (crashPresent)
                {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{crashedCar} was hit at {crashedCar[crashedIndex]}.");
                    break;
                }
            }
        }
        if (!crashPresent)
        {
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalPassedCars} total cars passed the crossroads.");
        }
    }
}

