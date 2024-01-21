namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int equalSum = int.Parse(Console.ReadLine());

            int count = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];
                for (int i2 = 0; i2 < numbers.Length; i2++)
                {
                    if ((currNumber + numbers[i2]) == equalSum)
                    {
                        if (i < i2)
                        {
                            Console.Write($"{numbers[i]} ");
                            Console.WriteLine(String.Join(" ", numbers[i2]));
                        }
                    }
                }
            }
            //int[] sumNumbers = new int[count];
            //Console.WriteLine(count);
        }
    }
}
