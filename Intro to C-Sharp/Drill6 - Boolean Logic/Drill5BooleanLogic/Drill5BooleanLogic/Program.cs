/*
EXERCISE: BOOLEAN LOGIC
Your job is to create a basic approval program for car insurance. It will ask the applicant some questions and return a “true” or “false” at the end as to whether or not the applicant qualified for car insurance.

REQUIREMENTS
Ask the following questions:

What is your age?

Have you ever had a DUI?

How many speeding tickets do you have?

Use the following qualification rules to determine if the applicant qualifies for car insurance:

Applicants must be over 15 years old.

Applicants must not have any DUI’s.

Applicants must not have more than 3 speeding tickets.

Print the result of the boolean expression created from the above business rules.

EXAMPLE OUTPUT
What is your age?
32
Have you ever had a DUI?
false
How many speeding tickets do you have?
1
Qualified?
true
*/
using System;

namespace Drill5BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (Please enter 'true' or 'false')");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());            
            Console.WriteLine("How many speeding tickets do you have?");
            int userSpeedingTickets = Convert.ToInt32(Console.ReadLine());
            bool isQualified = userAge > 15 && userDUI == false && userSpeedingTickets <= 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
