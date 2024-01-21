namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());
            int thirdN = int.Parse(Console.ReadLine());
            int fourthN = int.Parse(Console.ReadLine());

            int result = ((firstN + secondN) / thirdN) * fourthN;
            Console.WriteLine(result);
        }
    }
}