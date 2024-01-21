namespace MyApp // Note: actual namespace depends on the project name.
{
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string maxModel = string.Empty;
            BigInteger maxValue = BigInteger.MinusOne;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine()); // decimal ? or biginteger
                double height = double.Parse(Console.ReadLine());

                BigInteger value = (BigInteger)(Math.PI * (radius * radius) * height);
                if (value > maxValue)
                {
                    maxValue = value;
                    maxModel = model;
                }
            }
            Console.WriteLine(maxModel);
        }
    }
}