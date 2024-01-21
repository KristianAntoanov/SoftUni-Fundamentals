namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger factoriel = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}