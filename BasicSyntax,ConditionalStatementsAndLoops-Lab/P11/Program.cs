using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());

            for (int i = start; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
            if (start > 10)
            {
                Console.WriteLine($"{n} X {start} = {n * start}");
            }
        }
    }
}