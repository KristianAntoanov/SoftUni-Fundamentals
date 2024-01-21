namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));

        }
        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEven = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                if (currentNumber % 2 == 0)
                {
                    sumOfEven += currentNumber;
                }
                number /= 10;
            }
            return sumOfEven;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sumOfOdd = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                if (currentNumber % 2 != 0)
                {
                    sumOfOdd += currentNumber;
                }
                number /= 10;
            }
            return sumOfOdd;
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            return result;
        }
    }
}