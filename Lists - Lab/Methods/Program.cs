namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // numbers.Sum()
            Console.WriteLine(numbers.Sum());

            // Min
            Console.WriteLine(numbers.Min());

            // Max
            Console.WriteLine(numbers.Max());

            // Average   ---> 
            Console.WriteLine(numbers.Average());

            // Skip   ---> skip first 2 elements from left to right
            Console.WriteLine(string.Join(" ", numbers.Skip(2)));

            // Take   ---> take 2 elements from left to right
            Console.WriteLine(numbers.Take(2));

            // OrderBy   ---> 
            Console.WriteLine(string.Join(" ", numbers.OrderBy(x => x))); // .Sort

            // OrderByDescending
            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x)));

            // Where   ---> Where all the numbers are Even
            Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));

            // Where   ---> Where all the numbers are Odd
            Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));

            // Where   ---> Where all the numbers are bigger then 5
            Console.WriteLine(string.Join(" ", numbers.Where(x => x > 5)));

            // All   ---> returns bool   if all numbers are Even - True |
            Console.WriteLine(string.Join(" ", numbers.All(x => x % 2 == 0)));

            // Any   ---> Is there at least one ? 
            Console.WriteLine(string.Join(" ", numbers.Any(x => x % 2 == 0)));

            // Select
            Console.WriteLine(string.Join(" ", numbers.Select(x => x + 2)));
        }
    }
}