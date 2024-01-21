using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}