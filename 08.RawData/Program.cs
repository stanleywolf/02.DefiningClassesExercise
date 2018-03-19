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

            var name = input[0];
            var engine = new Engine(int.Parse(input[2]));
            var cargo = new Cargo(input[4]);
            var tires = new Tire[]
            {
                new Tire(double.Parse(input[5])), 
                new Tire(double.Parse(input[7])),
                new Tire(double.Parse(input[9])),
                new Tire(double.Parse(input[11]))
            };

            cars.Add(new Car(name, engine, cargo, tires));
        }
        var command = Console.ReadLine();

        //Console.WriteLine(string.Join(Environment.NewLine, cars
        //    .Where(c => c.Cargo.CargoType == command && command == "fragile"
        //        ? c.Tires
        //              .Where(t => t.Pressure < 1)
        //              .FirstOrDefault() != null
        //        : c.EnginePower.EnginePower > 250)
        //    .Select(c => c.Name)));

        if (command == "fragile")
        {
            foreach (var car in cars.Where(a=>a.Cargo.CargoType==command).Where(b=>b.Tires.Where(a=>a.Pressure<1).FirstOrDefault() != null))
            {
                Console.WriteLine(car.Name);
            }
        }
        else
        {
            foreach (var car in cars.Where(b=>b.Cargo.CargoType==command).Where(a=>a.EnginePower.EnginePower>250))
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}