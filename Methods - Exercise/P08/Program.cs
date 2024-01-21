namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double firstResult = GetFactorialNum(n);
            double secondResult = GetFactorialNum(n2);
            double result = firstResult / secondResult;
            Console.WriteLine($"{result:f2}");
        }
        static double GetFactorialNum(int n)
        {
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}