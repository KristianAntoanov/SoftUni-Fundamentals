namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                if (!IdExists(persons, id))
                {
                    Person currPerson = new Person(name, id, age);
                    persons.Add(currPerson);
                }
                else
                {
                    Person toUpdate = persons
                        .First(x => x.Id == id);
                    toUpdate.Name = name;
                    toUpdate.Age = age;
                }
            }
            foreach (Person person in persons.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
        static bool IdExists(List<Person> persons, string id)
        {
            return persons.Any(x => x.Id == id);
        }
    }
    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}