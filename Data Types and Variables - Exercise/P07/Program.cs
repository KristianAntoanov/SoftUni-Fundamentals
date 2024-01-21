using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int tank = 0;

            for (int i = 1; i <= n; i++)
            {
                int water = int.Parse(Console.ReadLine());

                tank += water;
                if (tank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    tank -= water;
                }
              
            }
            Console.WriteLine(tank);
        }
    }
}