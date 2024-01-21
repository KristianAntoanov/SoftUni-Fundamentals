namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine(pow(n, n2));
        }

        private static double pow(double n, double n2)
        {
            double result = Math.Pow(n, n2);
            return result;
        }
    }
}