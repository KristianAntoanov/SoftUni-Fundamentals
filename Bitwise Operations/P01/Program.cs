using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int shiftedNumber = number >> 1;
            int lsb = shiftedNumber & 1;

            Console.WriteLine(lsb);
        }
    }
}