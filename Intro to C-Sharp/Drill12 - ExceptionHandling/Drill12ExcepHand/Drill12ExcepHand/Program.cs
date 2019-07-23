/*
 EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

2. Run that code, entering in non-zero numbers as the user. Look at the displayed results.

3. Run that code, entering in zero as the number to divide by. Note any error messages you get.

4. Run that code, entering in a string as the number to divide by. Note any error messages you get.

5. Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program display a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
 */

using System;
using System.Collections.Generic;

namespace Drill12ExcepHand
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            //The for loop below adds ints 1-10 into the 'numbers' list.
            for(int i = 1; i < 11; i++)
            {
                numbers.Add(i);
            }

            bool continueToRun = true;

            while (continueToRun)
            {
                try
                {
                    Console.WriteLine("Each number in the 'numbers' list will be divided by the integer you enter.\nPlease enter an integer:");
                    int numberEntered = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int divisionResult = numbers[i] / numberEntered;
                        Console.WriteLine(numbers[i] + " / " + numberEntered + " = " + divisionResult);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nERROR: " + ex.Message);
                    Console.WriteLine("You must enter an integer.\n");
                    continueToRun = true;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("\nERROR: " + ex.Message);
                    Console.WriteLine("You must enter an integer that is not zero.\n");
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
