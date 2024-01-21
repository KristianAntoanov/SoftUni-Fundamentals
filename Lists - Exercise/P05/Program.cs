namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bomb = input[0];
            int power = input[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int startIndex = i - power;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    int finishIndex = i + power + 1;
                    if (finishIndex > numbers.Count)
                    {
                        finishIndex = numbers.Count;
                    }

                    for (int i2 = startIndex; i2 < finishIndex; i2++)
                    {
                        numbers[i2] = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers.Sum()));
        }
    }
}