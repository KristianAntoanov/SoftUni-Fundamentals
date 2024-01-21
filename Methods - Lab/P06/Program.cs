namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());

            double area = getArea(n1, n2);
            Console.WriteLine(area);
        }
        static double getArea(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}