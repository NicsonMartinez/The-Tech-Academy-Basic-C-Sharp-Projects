/*
EXERCISE:
1. Create a const variable

2. Create a variable using the keyword "var".

3. Chain two constructors together.

By: Nicson Martinez
Date: 8/12/19
*/
 using System;

namespace Drill28Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE: Here is constant int, 'num' which never gets used in the 
            //      program but was declaired.
            const int num = 100;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite sport? (leave blank if not applicable)");
            string sport = Console.ReadLine();

            if (string.IsNullOrEmpty(sport))
            {
                //NOTE: Here is the creation of a variable using 'var'.
                var person = new Person(name);
                person.FavSport();
            }
            else
            {
                var person = new Person(name, sport);
                person.FavSport();
            }

            Console.ReadLine();
        }
    }
    public class Person
    {
        //NOTE: Here are my constructor call chain.
        public Person(string name) : this(name, "N/A") { }
        public Person(string name, string sport)
        {
            Name = name;
            Sport = sport;
        }

        public void FavSport()
        {
            Console.WriteLine("\nHello {0}, Your favorite sport is {1}.", Name, Sport);
        }

        public string Name { get; set; }
        public string Sport { get; set; }
    }
}
