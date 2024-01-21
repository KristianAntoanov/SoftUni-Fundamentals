
namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumOfEven = 0;
            int sumOfOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];
                if (currNumber % 2 == 0)
                {
                    sumOfEven += currNumber;
                }
                else
                {
                    sumOfOdd += currNumber;
                }
            }
            Console.WriteLine(sumOfEven);
        }
    }
}