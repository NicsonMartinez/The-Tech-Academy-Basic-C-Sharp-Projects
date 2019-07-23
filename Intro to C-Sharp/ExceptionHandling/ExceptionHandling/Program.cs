using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            }
            //NOTE: If we wanted to catch all exceptions we would do 'Exception ex'.
            //NOTE: Below we are catching an specific exception, 'FormatException' and giving it a variable 'ex'.
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message); //NOTE: This integrated message says "Input string was not n a correct format."
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            //NOTE: Below is the axception to catch any other exceptions.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //NOTE: 'finally' executes no matter what. 'finally' was created in the case that an exception is executed, sometimes
            //that exception may have a 'return;' and may stop the entire program. 'finally' is used so that, regardless of what happened
            //in the try-catch. It will run and it will allow the user see other stuff they wouldn't have been able to see without it.
            finally
            {
                Console.ReadLine();
            }

        }

    }
}
