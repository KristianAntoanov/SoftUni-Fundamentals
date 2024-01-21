using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n * 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum += i;
                }

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}