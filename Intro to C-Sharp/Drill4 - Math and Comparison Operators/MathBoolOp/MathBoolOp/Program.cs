/*
EXERCISE:
CREATE A CONSOLE APPLICATION THAT DOES THE FOLLOWING:
1. Takes an input from the user, multiplies it by 50, and prints the result to the console. 
(Note: make sure your code can take inputs larger than 10,000,000).

2. Takes an input from the user, adds 25 to it, and prints the result to the console.

3. Takes an input from the user, divides it by 12.5, and prints the result to the console.

4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.

5. Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).
*/

using System;

namespace MathBoolOp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Please enter a number so that we can multiply it by 50: ");
            string userInput1String = Console.ReadLine();
            double userInput1Double = Convert.ToDouble(userInput1String);
            double multTotal = userInput1Double * 50.0;
            Console.WriteLine("The number you entered, '" + userInput1Double + "', times 50 is equal to " + multTotal + ".\n");

            Console.WriteLine("2. Please enter a number so that we can add 25 to it: ");
            string userInput2String = Console.ReadLine();
            double userInput2Double = Convert.ToDouble(userInput2String);
            double sumTotal = userInput2Double + 25.0;
            Console.WriteLine("The number you entered, '" + userInput2Double + "', plus 25 is equal to " + sumTotal + ".\n");

            Console.WriteLine("3. Please enter a number so that we can divide it by 12.5: ");
            string userInput3String = Console.ReadLine();
            double userInput3Double = Convert.ToDouble(userInput3String);
            double divTotal = userInput3Double / 12.5;
            Console.WriteLine("The number you entered, '" + userInput3Double + "', divided by 12.5 is equal to " + divTotal + ".\n");

            Console.WriteLine("4. Please enter a number so that we can check if it is greater than 50: ");
            string userInput4String = Console.ReadLine();
            double userInput4Double = Convert.ToDouble(userInput4String);
            bool isGreaterThanFifty = userInput4Double > 50.0;
            Console.WriteLine("Is the number you entered, '" + userInput4Double + "', greater than 50? We determined that is in fact '" + isGreaterThanFifty + "'.\n");

            Console.WriteLine("5. Please enter a number so that we can divide it by 7 and tell you the remainder in that division: ");
            string userInput5String = Console.ReadLine();
            double userInput5Double = Convert.ToDouble(userInput5String);
            double remainder = userInput5Double % 7;
            Console.WriteLine("The number you entered, '" + userInput5Double + "', divided by 7 gives us a remainder of " + remainder + ".");
            Console.ReadLine();
        }
    }
}
