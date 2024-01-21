namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            // first long way to solve this problem !
            //string[] input = Console.ReadLine()
            //    .Split('\\', StringSplitOptions.RemoveEmptyEntries);
            //string file = input[input.Length - 1];
            //string[] fileInfo = file.Split(".");
            //Console.WriteLine($"File name: {fileInfo[0]}");
            //Console.WriteLine($"File extension: {fileInfo[1]}");

            string input = Console.ReadLine();
            string[] fileInfo = input
                .Split('\\')
                .Last()
                .Split('.')
                .ToArray();
            Console.WriteLine($"File name: {string.Join('.', fileInfo[0..^1])}");
            Console.WriteLine($"File extension: {fileInfo[^1]}");
        }
    }
}