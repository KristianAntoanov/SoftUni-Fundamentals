namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int countArr = 1;
            int maxCount = 0;
            int start = 0;

            for (int i = 0; i < n.Length; i++)
            {

                if (n[i] == n[i + 1])
                {
                    countArr++;
                }
                else
                {
                    countArr = 1;
                }
                if (countArr > maxCount)
                {
                    start = i;
                    maxCount = countArr;
                }

            }
            int[] equalNumbers = new int[maxCount];
            for (int i = 0; i < maxCount; i++)
            {
                equalNumbers[i] = n[start];
            }
            if (n.Length < 2)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.Write(String.Join(" ", equalNumbers));
            }

        }
    }
}