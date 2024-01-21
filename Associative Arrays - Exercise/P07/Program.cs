namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            string input = string.Empty;
            bool ifContains = true;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string companyName = cmdArgs[0];
                string employeeId = cmdArgs[1];
                ifContains = true;
                if (!company.ContainsKey(companyName))
                {
                    company[companyName] = new List<string>();
                }
                List<string> companys = company[companyName];
                if (!IdContains(companys, employeeId))
                {
                    company[companyName].Add(employeeId);
                }
            }
            foreach (var key in company)
            {
                Console.WriteLine($"{key.Key}");
                foreach (var item in key.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
        static bool IdContains(List<string> employees, string id)
        {
            return employees.Any(x => x == id);
        }
    }
}