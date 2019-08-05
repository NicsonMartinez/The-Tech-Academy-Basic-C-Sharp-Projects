/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Make the Employee class take a generic type parameter.

2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

3. Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.

4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.

5. Create a loop that prints all of the Things to the Console
*/
using System.Collections.Generic; //NOTE: This is a must when using Generics (eg. Lists)
using System;

namespace Drill22Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();

            //NOTE: Since 'Things' is just a property at this point, it must be instantiated before being able to add elements to it.
            employee.Things = new List<string>();

            employee.Things.Add("Thing1");
            employee.Things.Add("Thing2");
            employee.Things.Add("Thing3");

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>();
            employee2.Things.Add(1);
            employee2.Things.Add(2);
            employee2.Things.Add(3);

            Console.WriteLine("These are all the things from the list of strings, 'employee.Things':");
            foreach(string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine("\nThese are all the things from the list of ints, 'employee.Things':");
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
