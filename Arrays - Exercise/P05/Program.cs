namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.TrimEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                bool isTopInteger = true;

                for (int i2 = i + 1; i2 < numbers.Length; i2++)
                {
                    int nextInteger = numbers[i2];

                    if (nextInteger >= currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}