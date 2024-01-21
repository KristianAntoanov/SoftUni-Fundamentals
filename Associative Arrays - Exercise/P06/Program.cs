namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Xml.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string nameOfSudent = Console.ReadLine();
                double gradeOfStudent = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(nameOfSudent))
                {
                    students[nameOfSudent] = new List<double>();
                }
                students[nameOfSudent].Add(gradeOfStudent);

            }
            foreach (var kvp in students.Where(x => x.Value.Average(x => x) >= 4.50))
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value.Average(x => x)):f2}");
            }
        }
    }
}