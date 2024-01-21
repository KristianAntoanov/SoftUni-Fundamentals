using System;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double priceForOnePerson = 0;
            double totalPrice = 0;

            if (dayOfWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    priceForOnePerson = 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    priceForOnePerson = 10.9;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceForOnePerson = 15;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    priceForOnePerson = 9.8;
                }
                else if (typeOfGroup == "Business")
                {
                    priceForOnePerson = 15.6;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceForOnePerson = 20;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    priceForOnePerson = 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    priceForOnePerson = 16;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceForOnePerson = 22.5;
                }
            }

            totalPrice = countPeople * priceForOnePerson;
            if (typeOfGroup == "Students" && countPeople >= 30)
            {
                totalPrice *= 0.85;
            }
            if (typeOfGroup == "Business" && countPeople >= 100)
            {
                totalPrice -= 10 * priceForOnePerson;
            }
            if (typeOfGroup == "Regular" && countPeople >= 10 && countPeople <= 20)
            {
                totalPrice *= 0.9;
            }
            Console.WriteLine($"Total price: {totalPrice:D6}");

        }
    }
}