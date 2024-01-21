using System;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int ascii = (int)character;
                sum += ascii;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}