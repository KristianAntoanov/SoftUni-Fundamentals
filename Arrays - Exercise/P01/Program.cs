namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());

                numbers[i] = currNum;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(sum);
        }
    }
}