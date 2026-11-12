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
            person.Age = "What is your age: ".RequestInt(1,120);
            person.AccountBalance = "How much do you have on your account: ".RequestDecimal();

            Console.WriteLine($"Welcome {person.FirstName} {person.LastName} that is {person.Age} years old and has {person.AccountBalance} EUR on their account!");

            Console.ReadLine();
        }
    }
}
