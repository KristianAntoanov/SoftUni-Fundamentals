namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                coffe(quantity);
            }
            else if (product == "water")
            {
                water(quantity);
            }
            else if (product == "coke")
            {
                coke(quantity);
            }
            else if (product == "snacks")
            {
                snacks(quantity);
            }

        }

        private static void snacks(int quantity)
        {
            Console.WriteLine($"{quantity * 2.00:f2}");
        }

        private static void coke(int quantity)
        {
            Console.WriteLine($"{quantity * 1.40:f2}");
        }

        private static void water(int quantity)
        {
            Console.WriteLine($"{quantity * 1.00:f2}");
        }

        private static void coffe(int quantity)
        {
            Console.WriteLine($"{quantity * 1.50:f2}");
        }
    }
}