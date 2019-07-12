using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favrite number." : "You do not have an awesome favorite number.";

            Console.WriteLine(result);
            Console.ReadLine();

            //-----------------------------------------------------------------------------------------------------------------------

            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi " + name + ", what is the temperature where you are?");
            //int currentTempersture = Convert.ToInt32(Console.ReadLine());

            //if (currentTempersture == roomTemperature)
            //{
            //    Console.WriteLine("It is excatly room temperature.");
            //}
            //else if (currentTempersture > roomTemperature)
            //{ 
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTempersture)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uuuuuuuuhhh.. Something went wrong..");
            //}


            //-----------------------------------------------------------------------------------------------------------------------
            //int currentTemperature = 80;
            //int roomTemperature = 70;
            //NOTE: ternary operator (ternary means a third) is used to shorten the amount of else if statements there are
            /*NOTE: you are asking it a question 'currentTemperature == roomTemperature ?' if that is true, the value following the
            question mark '?' ("It is room temp.") gets assigned to 'comparisonResult' variable and if the answer to the question is false, 
            then the value following the colen ':' ("It is not room temp.") gets assigned to 'comparisonResult'. */

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);

            //-----------------------------------------------------------------------------------------------------------------------

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            //Console.ReadLine();
        }
    }
}
