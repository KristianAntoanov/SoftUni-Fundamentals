namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);

        }
        static void Matrix (int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int i2 = 0; i2 < n; i2++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}