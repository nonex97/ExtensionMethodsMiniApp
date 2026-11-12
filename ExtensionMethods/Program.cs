using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "What is your first name: ".RequestString();

            person.LastName = "What is your last name: ".RequestString();

            person.Age = "What is your age: ".RequestInt(0,120);

            //person.Age = ConsoleHelper.RequestInt("What is your age: ", 0, 120); // this is how it would look if we didn't make it an extension method

            Console.WriteLine($"First name: {person.FirstName}");
            Console.WriteLine($"Last name: {person.LastName}");
            Console.WriteLine($"Age: {person.Age}");

            Console.ReadLine();
        }
    }
}
