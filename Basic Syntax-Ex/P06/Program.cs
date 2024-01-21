using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int copyNum = n;
            int sumOfFac = 0;
            while (copyNum > 0)
            {
                int lastNum = copyNum % 10;
                copyNum /= 10;
                int factorial = 1;
                for (int i = 2; i <= lastNum; i++)
                {
                    factorial *= i;
                }
                sumOfFac += factorial;
                factorial = 1;
                
            }
            if (sumOfFac == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}