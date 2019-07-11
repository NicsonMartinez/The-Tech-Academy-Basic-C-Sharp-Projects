/*
EXERCISE: MATH AND COMPARISON OPERATORS
Your job is to create an anonymous income comparison program.

REQUIREMENTS
The program must start by printing “Anonymous Income Comparison Program” to the screen.

It must then print “Person 1” to the screen and get the following details:

Hourly Rate

Hours worked per week

It must then print “Person 2” to the screen and then get the following details:

Hourly rate

Hours worked per week

It must then print to the screen “Weekly salary of Person 1:” and write the exact salary below it.

It must then print to the screen “Weekly salary of Person 2:” and write the exact salary below it.

It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.

EXAMPLE
Anonymous Income Comparison Program
Person 1
Hourly Rate?
15
Hours worked per week?
40
Person 2
Hourly Rate?
20
Hours worked per week?
40
Weekly salary of Person 1:
600
Weekly salary of Person 2:
800
Does Person 1 make more money than Person 2?
false
*/


using System;

namespace Drill5Comp
{
    class IncomeComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string person1HourlyRate = Console.ReadLine();
            double person1HourlyRateDouble = Convert.ToDouble(person1HourlyRate);
            Console.WriteLine("Hours worked per week?");
            string person1HrsPerWeek = Console.ReadLine();
            double person1HrsPerWeekDouble = Convert.ToDouble(person1HrsPerWeek);
            double person1WeeklySalaryDouble = person1HourlyRateDouble * person1HrsPerWeekDouble;

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly Rate?");
            string person2HourlyRate = Console.ReadLine();
            double person2HourlyRateDouble = Convert.ToDouble(person2HourlyRate);
            Console.WriteLine("Hours worked per week?");
            string person2HrsPerWeek = Console.ReadLine();
            double person2HrsPerWeekDouble = Convert.ToDouble(person2HrsPerWeek);
            double person2WeeklySalaryDouble = person2HourlyRateDouble * person2HrsPerWeekDouble;

            Console.WriteLine("\nWeekly salary of Person 1:");
            Console.WriteLine(person1WeeklySalaryDouble);
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine(person2WeeklySalaryDouble);
            Console.WriteLine("Does Person 1 make more money than Person 2?:");
            bool person1MakesMore = person1WeeklySalaryDouble > person2WeeklySalaryDouble;
            Console.WriteLine(person1MakesMore);
            Console.ReadLine();

        }
    }
}
