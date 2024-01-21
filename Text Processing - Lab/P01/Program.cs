namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;

            while ((word = Console.ReadLine()) != "end")
            {
                char[] reversedWord = word.Reverse().ToArray();
                string result = new string(reversedWord);
                Console.WriteLine($"{word} = {result}");
            }
        }
    }
}