namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
               .Split()
               .Where(x => x.Length % 2 == 0)
               .ToList()
               .ForEach(Console.WriteLine);
        }
    }
}