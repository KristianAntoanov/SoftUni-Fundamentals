namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split();
            string[] secondArr = Console.ReadLine()
                .Split();

            string[] compares = new string[firstArr.Length];

            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int i2 = 0; i2 < secondArr.Length; i2++)
                {
                    if (firstArr[i] == secondArr[i2])
                    {
                        compares[i2] = secondArr[i2]; 
                    }
                }
            }

            //Console.WriteLine(string.Join(" ", compares));
            foreach (var item in compares)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}