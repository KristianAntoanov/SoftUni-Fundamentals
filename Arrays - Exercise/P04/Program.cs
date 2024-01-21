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
            int numOfRotation = int.Parse(Console.ReadLine());

            
            for (int i2 = 0; i2 < numOfRotation; i2++)
            {
                int firstEl = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i - 1] = numbers[i];
                }
                numbers[numbers.Length - 1] = firstEl;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}