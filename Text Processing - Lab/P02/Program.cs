namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            string result = string.Empty;

            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result += item;
                }
            }
            Console.WriteLine(result);
        }
    }
}