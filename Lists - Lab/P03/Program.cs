namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int n = Math.Min(firstNumbers.Count, secondNumbers.Count);

            for (int i = 0; i < n; i++)
            {
                result.Add(firstNumbers[i]);
                result.Add(secondNumbers[i]);
            }
            if (firstNumbers.Count > secondNumbers.Count)
            {
                for (int i = n; i < firstNumbers.Count; i++)
                {
                    result.Add(firstNumbers[i]);
                }
            }
            else if (firstNumbers.Count < secondNumbers.Count)
            {
                for (int i = n; i < secondNumbers.Count; i++)
                {
                    result.Add(secondNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}