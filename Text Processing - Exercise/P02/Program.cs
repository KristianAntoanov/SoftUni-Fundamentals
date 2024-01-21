namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            GetStringSum(input);
        }

        private static void GetStringSum(string[] input)
        {
            string firstStr = input[0];
            string secondStr = input[1];

            int sum = 0;
            int minLength = Math.Min(firstStr.Length, secondStr.Length);
            int maxLength = Math.Max(firstStr.Length, secondStr.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += firstStr[i] * secondStr[i];
            }
            for (int i = minLength; i < maxLength; i++)
            {
                if (firstStr.Length > secondStr.Length)
                {
                    sum += firstStr[i];
                }
                else
                {
                    sum += secondStr[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}