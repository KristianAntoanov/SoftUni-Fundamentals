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
                    triangle(i);
                    Console.WriteLine();
                }

                for (int i = n -1 ; i >= 1; i--)
                {
                    triangle(i);
                    Console.WriteLine();
                }
            }

            private static void triangle(int i)
            {
                for (int i2 = 1; i2 <= i; i2++)
                {
                    Console.Write(i2 + " ");
                }
            }
        }
    }