namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string specialword = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(specialword))
            {
                int startIndex = text.IndexOf(specialword);

                text = text.Remove(startIndex, specialword.Length);
            }
            Console.WriteLine(text);
        }
    }
}