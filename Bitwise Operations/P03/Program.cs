using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int possition = int.Parse(Console.ReadLine());

            int mask = 1 << possition;
            mask = ~mask;

            int result = number & mask;
            Console.WriteLine(result);
        }
    }
}