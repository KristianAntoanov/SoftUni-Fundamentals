namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int i2 = 1; i2 <= i; i2++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}