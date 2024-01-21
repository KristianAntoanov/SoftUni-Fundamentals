
namespace MyApp // Note: actual namespace depends on the project name.
{
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger snowballValue= BigInteger.MinusOne;

            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for (int i = 1; i <= numOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger finalResult = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (finalResult > snowballValue)
                {
                    snowballValue = finalResult;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                }

            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {snowballValue} ({maxQuality})");
        }
    }
}