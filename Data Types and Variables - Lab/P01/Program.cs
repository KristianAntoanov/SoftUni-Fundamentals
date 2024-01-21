using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double kms = meters / 1000f;

            Console.WriteLine($"{kms:f2}");
        }
    }
}