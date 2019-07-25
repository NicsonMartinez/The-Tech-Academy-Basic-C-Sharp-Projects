/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. 
The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.

2. In the Main() program, ask the user what number they want to do the math operations on.

3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

By: Nicson Martinez
Date: 7/25/19
*/
using System;

namespace Drill13Fuctions
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continueToRun = true;

            while (continueToRun)
            {
                Console.WriteLine("Please type an integer and we will:");
                Console.WriteLine("1. Add 100 to the int provided.");
                Console.WriteLine("2. Subtract 100 to the int provided.");
                Console.WriteLine("3. Multiply by 100 to the int provided.");

                try
                {
                    int enteredInt = Convert.ToInt32(Console.ReadLine());

                    int addedInt = CoolMath.Plus100(enteredInt);
                    int subtractedInt = CoolMath.Minus100(enteredInt);
                    int mutipliedInt = CoolMath.Times100(enteredInt);

                    Console.WriteLine("\nThe int provided, '" + enteredInt + "' plus 100 is = " + addedInt);
                    Console.WriteLine("The int provided, '" + enteredInt + "' minus 100 is = " + subtractedInt);
                    Console.WriteLine("The int provided, '" + enteredInt + "' times 100 is = " + mutipliedInt);
                    Console.ReadLine();

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nERROR: " + ex.Message);
                    Console.WriteLine("You must enter an integer.\n");
                    continueToRun = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("\nERROR: " + ex.Message);
                    Console.WriteLine("The min Int32 value you may enter is -2,147,483,648.");
                    Console.WriteLine("The max Int32 value you may enter is 2,147,483,647.");
                    Console.WriteLine("Any integers lower than the min, or highter than the max will not work.\n");
                    continueToRun = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: Something went wrong, please try again.\n");
                    continueToRun = true;
                }
            }
            
        }
    }
}
