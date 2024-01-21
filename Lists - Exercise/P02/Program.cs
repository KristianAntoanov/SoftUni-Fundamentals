namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input
                    .Split();

                if (cmdArgs[0] == "Delete")
                {
                    int number1 = int.Parse(cmdArgs[1]);

                    numbers.RemoveAll(x => x == number1);
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int number1 = int.Parse(cmdArgs[1]);
                    int number2 = int.Parse(cmdArgs[2]);

                    numbers.Insert(number2, number1);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}