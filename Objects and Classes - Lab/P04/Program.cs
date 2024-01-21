namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] info = input
                    .Split();
                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string homeTown = info[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                bool exists = false;
                foreach (var currStudent in students)
                {
                    if (currStudent.FirstName == student.FirstName && currStudent.LastName == student.LastName)
                    {
                        currStudent.Age = student.Age;
                        currStudent.HomeTown = student.HomeTown;
                        exists = true;
                    }
                }
                if (!exists)
                {
                    students.Add(student);
                }
            }
            string city = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {
                Student currStudent = students[i];
                if (currStudent.HomeTown == city)
                {
                    Console.WriteLine($"{currStudent.FirstName} {currStudent.LastName} is {currStudent.Age} years old.");
                }
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}