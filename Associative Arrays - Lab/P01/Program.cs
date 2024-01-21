namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

            double[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var item in inputNumbers)
            {
                if (!numbers.ContainsKey(item))
                {
                    numbers.Add(item, 0);
                }
                numbers[item] += 1;
            }
            foreach (var curNum in numbers)
            {
                Console.WriteLine($"{curNum.Key} -> {curNum.Value}");
            }
        }
    }
}