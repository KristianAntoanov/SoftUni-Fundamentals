namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (string item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1];

                string num = item[1..^1];
                double numFromString = double.Parse(num);

                if (char.IsUpper(firstLetter))
                {
                    int positionOfTheLetter = firstLetter - 64;
                    numFromString /= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    numFromString *= positionOfTheLetter;
                }
                if (char.IsUpper(lastLetter))
                {
                    int positionOfTheLetter = lastLetter - 64;
                    numFromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numFromString += positionOfTheLetter;
                }
                sum += numFromString;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}