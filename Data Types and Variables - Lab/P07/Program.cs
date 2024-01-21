using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string character = Console.ReadLine();

            Console.WriteLine($"{firstName}{character}{secondName}");
        }
    }
}