namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];

                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo[courseName] = new List<string>();
                }
                coursesInfo[courseName].Add(studentName);
            }
            foreach (var kvp in coursesInfo)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var studentName in kvp.Value)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}