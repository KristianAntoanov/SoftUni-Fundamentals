namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (calculation == "add")
            {
                Console.WriteLine(add(number1, number2));
            }
            else if (calculation == "subtract")
            {
                Console.WriteLine(subtract(number1, number2));
            }
            else if (calculation == "multiply")
            {
                Console.WriteLine(multiply(number1, number2));
            }
            else if (calculation == "divide")
            {
                Console.WriteLine(divide(number1, number2));
            }

        }

        private static int divide(int number1, int number2)
        {
            return number1 / number2;
        }

        private static int multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        private static int subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        private static int add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}