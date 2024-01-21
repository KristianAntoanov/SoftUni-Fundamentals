namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            double percent = (double)n * 0.5;

            while (n >= m)
            {
                count++;
                n -= m;
                if ( n == percent && y != 0)
                {
                    n /= y;
                }
            }   
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}