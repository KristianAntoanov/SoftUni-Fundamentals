namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SumOfTwoIntegers(n1, n2, n3));
        }
        static int SumOfTwoIntegers(int n1, int n2, int n3)
        {
            int sum = n1 + n2;
            int resultsubtract = subtractsOfTwoIntegers(sum, n3);
            return resultsubtract;
        }
        static int subtractsOfTwoIntegers(int sum, int n3)
        {
            int result = sum - n3;
            return result;
        }
    }
}