namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(calculation(a, @operator, b));
        }
        static double calculation(int a, char @operator, int b)
        {
            double result = 0;
            if (@operator == '+')
            {
                result = a + b;
            }
            else if (@operator == '-')
            {
                result = a - b;
            }
            else if (@operator == '*')
            {
                result = a * b;
            }
            else if (@operator == '/')
            {
                result = a / b;
            }
            return result;
        }
    }
}