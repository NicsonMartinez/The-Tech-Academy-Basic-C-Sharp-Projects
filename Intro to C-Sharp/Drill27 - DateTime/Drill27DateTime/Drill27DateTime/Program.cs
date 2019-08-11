/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Prints the current date and time to the console.

2. Asks the user for a number.

3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
By: Nicson Martinez
Date: 8/11/2019
*/
using System;

namespace Drill27DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will show you the exact date and time it will be in x hours:");
            Console.Write("Plase provide us with a an integer for x: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            //NOTE: Here I am converting double, 'userInput' into TimeSpan, 'hourInput'.
            TimeSpan hourInput = TimeSpan.FromHours(userInput);

            //NOTE: Here I am instantiating a DateTime object so i con assign it a value of 
            //      'DateTime.Now' which return a datetime of the time the that line is executed.
            DateTime rightNow = new DateTime();
            rightNow = DateTime.Now;

            //NOTE: Here I am adding TimeSpan, 'hourInput' to DateTime, 'rightNow' and storing it in
            //      DateTime, 'futureTime'.
            DateTime futureTime = rightNow.Add(hourInput);

            Console.WriteLine("\n'{0}' hours from now, it will be '{1}'.", userInput, futureTime);
            Console.ReadLine();
        }
    }
}
