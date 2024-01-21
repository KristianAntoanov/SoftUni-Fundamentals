namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Diagnostics;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] keyWord = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder text = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < keyWord.Length; i++)
            {
                text.Replace(keyWord[i], new string('*', keyWord[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}