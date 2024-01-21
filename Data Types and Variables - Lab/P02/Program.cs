using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bPounds = double.Parse(Console.ReadLine());

            double usDollars = bPounds * 1.31;

            Console.WriteLine($"{usDollars:f3}");
        }
    }
}