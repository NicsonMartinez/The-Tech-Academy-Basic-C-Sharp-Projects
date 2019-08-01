using System;
using System.Collections.Generic;
using System.Text;

namespace Drill20Interface
{
    class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("I Quit");
            Console.ReadLine();
        }

        
    }
}

