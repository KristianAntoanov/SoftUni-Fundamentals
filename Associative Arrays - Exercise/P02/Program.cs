namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                //First (Long) way to solve this problem
                //if (!resources.ContainsKey(input))
                //{
                //    resources.Add(input, quantity);
                //}
                //else
                //{
                //    resources[input] += quantity;
                //}

                //second way to solve this problem but there is also a shorter version!
                //if (!resources.ContainsKey(input))
                //{
                //    resources[input] = quantity;
                //}
                //else
                //{
                //    resources[input] += quantity;
                //}
                if (!resources.ContainsKey(input))
                {
                    resources[input] = 0;
                }
                resources[input] += quantity;
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}