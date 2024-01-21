namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char char1 = firstChar;
            char char2 = secondChar;

            if (firstChar > secondChar)
            {
                char1 = secondChar;
                char2 = firstChar;
            }
            GetCharsBetweenThem(char1, char2);
        }
        static void GetCharsBetweenThem (char char1,char char2)
        {
            for (int i = char1 + 1; i < char2; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}