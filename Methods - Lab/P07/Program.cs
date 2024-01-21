namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());
           
            Console.WriteLine(concatenate(name, n));

        }

        private static string concatenate(string name, int n)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += name;
            }
            return result;
        }
    }
}