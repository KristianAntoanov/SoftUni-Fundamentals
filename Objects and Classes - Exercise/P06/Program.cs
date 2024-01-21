namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            int countOfCars = 0;
            int countOfTrucks = 0;
            double AverageOfCars = 0;
            double AverageOfTrucks = 0;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicle = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = vehicle[0];
                string model = vehicle[1];
                string color = vehicle[2];
                int hP = int.Parse(vehicle[3]);
                Vehicle currVehicle = new Vehicle(type, model, color, hP);
                vehicles.Add(currVehicle);
                if (type == "car")
                {
                    countOfCars++;
                    AverageOfCars += hP;
                }
                else if (type == "truck")
                {
                    countOfTrucks++;
                    AverageOfTrucks += hP;
                }

            }
            string input2 = string.Empty;
            while ((input2 = Console.ReadLine()) != "Close the Catalogue")
            {
                string model = input2;
                foreach (Vehicle vehicle in vehicles)
                {
                    if (model == vehicle.Model)
                    {
                        Console.WriteLine($"Type: {char.ToUpper(vehicle.Type[0]) + vehicle.Type.Substring(1)}");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
                    }
                }
            }
            if (countOfCars > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {AverageOfCars / countOfCars:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (countOfTrucks > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {AverageOfTrucks / countOfTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

    }
}