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

            bool isTopInteger = false;
            int firstNum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = numbers[i];

                int leftSum = 0;
                for (int l = 0; l <= i; l++)
                {
                    leftSum += numbers[l];
                }

                int rightSum = 0;
                for (int r = i + 2; r < numbers.Length; r++)
                {
                    rightSum += numbers[r];
                }

                if (leftSum == rightSum)
                {
                    isTopInteger = true;
                }

                if (isTopInteger)
                {
                    if (leftSum == 0 && rightSum == 0 && currNumber == 0)
                    {
                        Console.WriteLine(0);
                        break;
                    }
                    Console.WriteLine(i + 1);
                    break;
                }

            }
            if (numbers.Length < 2)
            {
                Console.WriteLine(0);
            }
            else if (!isTopInteger)
            {
                Console.WriteLine("no");
            }
            
            
             
        }
    }
}