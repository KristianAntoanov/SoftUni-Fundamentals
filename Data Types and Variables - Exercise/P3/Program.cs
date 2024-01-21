using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());

            double result = numOfPeople / capacity;
            Console.WriteLine(Math.Ceiling(result);
        }
    }
}