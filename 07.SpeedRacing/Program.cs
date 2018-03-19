using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        var nums = int.Parse(Console.ReadLine());

        var cars = new List<Car>();
        for (int i = 0; i < nums; i++)
        {
            var input = Console.ReadLine().Split();
            var carModel = input[0];
            var fuel = double.Parse(input[1]);
            var fuelPerKm = double.Parse(input[2]);

            if (!cars.Any(a => a.Model == carModel))
            {
                var car = new Car(carModel,fuel,fuelPerKm);
                cars.Add(car);
            }            
        }
        var drive = string.Empty;
        while ((drive = Console.ReadLine()) != "End")
        {
            CarMoves(cars, drive);
        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
        }
       
    }

    private static void CarMoves(List<Car> cars, string drive)
    {
        var driveInput = drive.Split();
        var carModel = driveInput[1];
        var distance = double.Parse(driveInput[2]);
        var leftFuel = 0.0;
        foreach (var car in cars)
        {
            if (car.Model == carModel)
            {
                var possibleDistance = distance * car.FuelPerKm;
                if (IsEnought(possibleDistance, car.FuelAmount))
                {
                    car.FuelAmount -= possibleDistance;
                    car.Distance += distance;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }
    }

    private static bool IsEnought(double possibleDistance, double carFuelAmount)
    {
        if (possibleDistance <= carFuelAmount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
