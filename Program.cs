using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthApp.Model;

namespace HealthApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person(1, "Allen" , 28 , 1.75, 80.9),
                new Person(2, "Mary" , 25)
            };
            TakeUserInput(people);
        }
        static void TakeUserInput(Person[] people)
        {
            Person loggedInPerson = null;
            Console.WriteLine("Enter your id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Person person in people) 
            { 
                if (id == person.Id)
                    loggedInPerson = person;
            }
            Console.WriteLine(loggedInPerson);
            double calculatedBmi = Math.Round(Person.CalculateBmi(loggedInPerson.Height, loggedInPerson.Weight), 2);
            Console.WriteLine(Person.FindBodyType(calculatedBmi));
        }
    }
}
