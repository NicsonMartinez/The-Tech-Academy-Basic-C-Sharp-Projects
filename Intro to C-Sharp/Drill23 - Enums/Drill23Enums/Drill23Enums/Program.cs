/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create an enum for the days of the week.

2. Prompt the user to enter the current day of the week.

3. Assign the value to a variable of that enum data type you just created.

4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

For this drill, you'll need to do some additional research on how to parse enums.
*/

using System;
using System.Globalization;

namespace Drill23Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi user, please enter the day of the week.");
            string userInput = Console.ReadLine();

            //NOTE: This Creates a TextInfo based on the "en-US" culture.
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            //NOTE: This is done in the case that the user types something like 'monday' 'MONDAY' or even'mOnDAY'
            //      and converts it to 'Monday' so it can be conpared with the day string in the enum object.
            string userInputCapitalized = textInfo.ToTitleCase(userInput.ToLower());

            //NOTE: 'GetNames' retrieves an array of strings of the enum object set.
            foreach (string day in Enum.GetNames(typeof(DaysOfTheWeek)))
            {
                if (day == userInputCapitalized)
                {
                    Console.WriteLine("\nThe day you typed, " + userInputCapitalized + ", is an actual day of the week.");
                    break;
                }
                else
                {
                    Console.WriteLine("\nThe day you typed, " + userInput + ", is not actual day of the week.");

                    break;
                }
            }
            Console.ReadLine();
        }
    }

    enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
