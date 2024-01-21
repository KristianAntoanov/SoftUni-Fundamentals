namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleChar(word);

        }
        static void MiddleChar(string oneWord)
        {
            char[] arr = oneWord.ToCharArray();

            int mid = oneWord.Length - (oneWord.Length / 2);
            if (arr.Length % 2 == 0)
            {
                Console.WriteLine($"{arr[mid - 1]}{arr[mid]}");
            }
            else
            {
                Console.WriteLine($"{arr[mid - 1]}");
            }
        }
    }
}