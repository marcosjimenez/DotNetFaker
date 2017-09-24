using System;
using System.Collections.Generic;
using DotNetFaker;

namespace DotNetFakerTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // Configure Faker
            Faker personFaker = new Faker();
            
            // Add custom generator
            personFaker.AddGenerator(new IPGenerator(), "IPGenerator");

            List<string> names = new List<string>();
            names.Add("Pepito Perez");
            names.Add("Fulanito Antunez");
            names.Add("Sutanito Gutierrez");
            names.Add("Shurmano Gomez");
            names.Add("Suprimo de los Vientos");

            // Add values to Person name generator
            personFaker.AddList<string>(names, DotNetFaker.Core.StringLists.PersonName);

            //
            // Test model
            Person person = personFaker.GetFake<Person>();

            // Results
            Console.WriteLine("*** One instance *** ");
            Console.WriteLine();
            PrintPerson(person);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");

            Console.ReadLine();

            Console.WriteLine("********************");
            Console.WriteLine("*** 10 instances *** ");
            Console.WriteLine("********************");
            Console.WriteLine();
            List<Person> persons = personFaker.GetFake<Person>(10);
            foreach (Person item in persons)
                PrintPerson(item);

            Console.WriteLine();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }

        static void PrintPerson(Person person)
        {
            Console.WriteLine(string.Format("ID: {0}", person.ID));
            Console.WriteLine(string.Format("Name: {0}", person.Name));
            Console.WriteLine(string.Format("Address: {0}", person.Address));
            Console.WriteLine(string.Format("Company: {0}", person.Company));
            Console.WriteLine(string.Format("BornDate: {0:d}", person.BornDate));
            Console.WriteLine(string.Format("IP: {0:d}", person.IP));
            Console.WriteLine(string.Format("String: {0:d}", person.RandomString));
            Console.WriteLine();
        }
    }
}
