/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. 
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Drill21OpOverlo
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //NOTE: In order for me to overload an operator, '==', I MUST overload operator '!=' .
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}