using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int possition = int.Parse(Console.ReadLine());

            int shiftedNum = num >> possition;
            int lsb = shiftedNum & 1;

            Console.WriteLine(lsb);
        }
    }
}