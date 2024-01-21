namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            foreach (char item in text)
            {
                if (char.IsDigit(item))
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
            foreach (char item in text)
            {
                if (char.IsLetter(item))
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine();
            foreach (char item in text)
            {
                if (char.IsSymbol(item) || char.IsPunctuation(item))
                {
                    Console.Write(item);
                }
            }

        }
    }
}