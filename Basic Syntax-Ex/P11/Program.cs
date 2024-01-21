namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Runtime.ConstrainedExecution;

    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            double totalSum = 0;
            double OrderPrice = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                double PricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());
                OrderPrice = (days * capsuleCount) * PricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${OrderPrice:f2}");
                totalSum += OrderPrice;
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}