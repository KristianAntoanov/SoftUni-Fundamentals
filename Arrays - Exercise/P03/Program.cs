
namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int firstNum = numbers[0];
                int secondNum = numbers[1];
                if (i % 2 == 0)
                {
                    firstArr[i] = firstNum;
                    secondArr[i] = secondNum;
                }
                else
                {
                    secondArr[i] = firstNum;
                    firstArr[i] = secondNum;
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}