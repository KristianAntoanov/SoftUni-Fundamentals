namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                TopNumber(i);
            }
        }
        static void TopNumber(int n)
        {
            int digitSum = 0;
            int printNum = n;
            int count = 0;
            int currNum = 0;
            while (n > 0)
            {
                digitSum += n % 10;
                currNum = n % 10;
                n /= 10;
                if (currNum % 2 != 0)
                {
                    count++;
                }
            }

            if (digitSum % 8 == 0 && count > 1)
            {
                Console.WriteLine(printNum);
            }
             
        }
    }
}