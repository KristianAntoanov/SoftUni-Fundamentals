
namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
            

            for (int i = 0; i < numbers.Length; i++)
            {
                double number = numbers[i];
                double roundedNum = Math.Round(number, MidpointRounding.AwayFromZero);


                Console.WriteLine($"{Convert.ToDecimal(number)} => {Convert.ToDecimal(roundedNum)}");
            }
        }
    }
}