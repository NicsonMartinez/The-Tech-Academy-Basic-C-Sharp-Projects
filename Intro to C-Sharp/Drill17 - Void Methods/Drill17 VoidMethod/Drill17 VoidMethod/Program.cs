/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

2. In the Main() method, instantiate that class.

3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.

4. Create a method with output parameters.

5. Overload a method.

6. Declare a class to be static.
*/
using System;

namespace Drill17_VoidMethod
{
    //Number 6
    static class Program
    {
        static void Main(string[] args)
        {
            //Number 2
            OtherClass theObject = new OtherClass();

            //Number 3
            Console.WriteLine("Hello User! Please enter a number");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int result;
            theObject.DivideBy2(inputNum, out result);

            Console.WriteLine("The number entered, '{0}' divided by 2 is: {1}.", inputNum, result);

        }
    }
}
