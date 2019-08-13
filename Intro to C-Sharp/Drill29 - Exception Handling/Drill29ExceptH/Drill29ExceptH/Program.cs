/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Ask the user for his age.

2. Display the year user born.

3. Exceptions must be handled using "try .. catch".

4. Display appropriate error messages if user enters zero or negative numbers.

5. Display a general message if exception caused by anything else. 

By: Nicson Martinez
Date: 8/12/19
*/
using System;

namespace Drill29ExceptH
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                try
                {
                    Console.WriteLine("Hi use, what is you age?");
                    int userAge = Convert.ToInt32(Console.ReadLine());

                    if (userAge <= 0)
                    {
                        Console.WriteLine("It is impossible for your Age to be less than or equal to zero.");
                        keepRunning = true;
                    }
                    else
                    {
                        Console.WriteLine("Your age is {0}.", userAge);
                        keepRunning = false;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nERROR: " + ex.Message);
                    Console.WriteLine("You must enter an integer.\n");
                    keepRunning = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("\nERROR: " + ex.Message);
                    Console.WriteLine("The min Int32 value you may enter is -2,147,483,648.");
                    Console.WriteLine("The max Int32 value you may enter is 2,147,483,647.");
                    Console.WriteLine("Any integers lower than the min, or highter than the max will not work.\n");
                    keepRunning = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Something went wrong, please try again.\n");
                    keepRunning = true;
                }
            }
            Console.ReadLine();
        }
    }
}
