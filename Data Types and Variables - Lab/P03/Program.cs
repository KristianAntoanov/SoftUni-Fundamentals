using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal currNumber = decimal.Parse(Console.ReadLine());

                sum += currNumber;
            }
            Console.WriteLine(sum);
        }
    }
}