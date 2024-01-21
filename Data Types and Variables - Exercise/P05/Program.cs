namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            for (int i = from; i <= to; i++)
            {
                char ascii = (char)i;
                Console.Write($"{ascii} ");
            }


        }
    }
}