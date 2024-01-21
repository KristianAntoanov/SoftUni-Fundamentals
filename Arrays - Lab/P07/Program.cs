
namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            int i2 = 0;

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                sum += firstNumbers[i];
                i2 = i;

                if (firstNumbers[i] != secondNumbers[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
        
            }
            if (firstNumbers[i2] == secondNumbers[i2])
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}