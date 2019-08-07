/*
EXERCISE
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, 
   as well as an Id. At least two employees should have the first name "Joe".

2. Using a foreach loop, create a new list of all employees with the first name "Joe".

3. Do the same thing again, but this time with a lambda expression.

4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
By: Nicson Martinez
Date: 8/7/19
*/
using System;
using System.Collections.Generic;
using System.Linq; //NOTE: This is needed for the lambda functions.

namespace Drill25Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is my originial Employee List, which includes all of the employees created:");
            EmployeeStack employeeStack = new EmployeeStack();
            foreach (Employee employee in employeeStack.EmployeeList)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.Id);
            }

            Console.WriteLine("\nThis is a new Employee List with all first names 'Joe' - w/o using Lambda Experssion:");
            EmployeeStack employeeStack2 = new EmployeeStack();
            foreach(Employee employee in employeeStack2.EmployeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.Id);
                }
            }

            Console.WriteLine("\nThis is a new Employee List with all first names 'Joe' - using Lambda Experssion:");
            List<Employee> employeeStack3 = employeeStack.EmployeeList.Where(x => x.FirstName == "Joe").ToList();           
            foreach (Employee employee in employeeStack3)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.Id);
            }

            Console.WriteLine("\nThis is a new Employee List with Id number greater than 5 - using Lambda Experssion:");
            List<Employee> employeeStack4 = employeeStack.EmployeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in employeeStack4)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.Id);
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }

    public class EmployeeStack
    {
        public EmployeeStack()
        {
            EmployeeList = new List<Employee>();

            List<string> employeeFirstNames = new List<string>()
            {
                "Nicson", "Ben", "Kevin", "Jordan", "Mika",
                "Jan", "Joe", "Issa", "Kendra", "Joe"
            };

            List<string> employeeLastNames = new List<string>()
            {
                "Fox", "Sutton", "Barlow", "Fitzgerald", "Craig",
                "Mac", "Acosta", "Henderson", "Griffin", "Coleman"
            };

            List<int> employeeIds = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                employeeIds.Add(i + 1);
            }

            //NOTE: Since each list has the same amount of elements,'10', and since my goal was to
            //      assign each value in each list with the corresponding object respectively, I just
            //      created an employee in each iteration and assigned that specific employee 
            //      its property by matching indexes to assign values.

            for (int i = 0; i < 10; i++)
            {
                EmployeeList.Add(new Employee());
                EmployeeList[i].FirstName = employeeFirstNames[i];
                EmployeeList[i].LastName = employeeLastNames[i];
                EmployeeList[i].Id = employeeIds[i];
            }
        }
        public List<Employee> EmployeeList { get; set; }
    }
}
