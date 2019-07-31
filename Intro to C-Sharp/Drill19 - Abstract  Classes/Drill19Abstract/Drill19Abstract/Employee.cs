using System;
using System.Collections.Generic;
using System.Text;

namespace Drill19Abstract
{
    class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
