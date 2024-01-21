using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 0 && n <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (n > 2 && n <= 13)
            {
                Console.WriteLine("child");
            }
            else if (n > 13 && n <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (n > 19 && n <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (n >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}