using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            double horsepowerTrucks = 0;
            double horsepowerCars = 0;
            int countOfTrucks = 0;
            int countOfCars = 0;
            int count = 0;
            List<Vehicle> list = new List<Vehicle>();
            while (input[0] != "End")
            {
                count++;
                Vehicle vehicle = new Vehicle();
                {
                    vehicle.Type = UpperFirstChar(input[0]);
                    vehicle.Model = input[1];
                    vehicle.Color = input[2];
                    vehicle.Horsepower = double.Parse(input[3]);
                }
                if (list.Any(x => x.Model == vehicle.Model)) continue;
                if (vehicle.Type == "Truck")
                {
                    horsepowerTrucks += vehicle.Horsepower;
                    countOfTrucks++;
                }
                else if (vehicle.Type == "Car")
                {
                    horsepowerCars += vehicle.Horsepower;
                    countOfCars++;
                }
                list.Add(vehicle);

                input = Console.ReadLine().Split().ToList();
            }

            string command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                PrintInfo(list, command);

                command = Console.ReadLine();
            }
            double averageCars = horsepowerCars / countOfCars;
            double averageTrucks = horsepowerTrucks / countOfTrucks;
            Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");
        }


        public class Vehicle
        {

            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public double Horsepower { get; set; }

        }
        static void PrintInfo(List<Vehicle> list, string command)
        {
            foreach (Vehicle vehicle in list.Where(x => x.Model == command))
            {
                Console.WriteLine($"Type: {vehicle.Type}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
            }
        }

        public static string UpperFirstChar(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            return char.ToUpper(input[0]) + input.Substring(1);
        }

    }
}
