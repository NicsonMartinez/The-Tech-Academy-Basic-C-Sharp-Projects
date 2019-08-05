/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. 
*/

using System;

namespace Drill21OpOverlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Id = 0001;
            employee1.Name = "Nicson";

            employee2.Id = 0002;
            employee2.Name = "Jesse";

            bool isEmployee = employee1 == employee2;

            Console.WriteLine("Does "+ employee1.Name + " and " + employee2.Name + "'s employee Ids match?: " + isEmployee);
            Console.ReadLine();
        }
    }
}
