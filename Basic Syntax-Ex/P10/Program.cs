namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Diagnostics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            Stopwatch sw = Stopwatch.StartNew();

            int headsetCount = lostGames / 2;
            int mouseCount = lostGames / 3;
            int keyboardCount = lostGames / 6;
            int displayCount = lostGames / 12;


            double expenses = (headsetCount * headsetPrice) + (mouseCount * mousePrice) + (keyboardCount * keyboardPrice) + (displayCount * displayPrice);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
            Console.WriteLine(sw.ElapsedMilliseconds);

        }
    }
}