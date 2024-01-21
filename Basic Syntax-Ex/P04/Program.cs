using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int lastN = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = firstN; i <= lastN; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}