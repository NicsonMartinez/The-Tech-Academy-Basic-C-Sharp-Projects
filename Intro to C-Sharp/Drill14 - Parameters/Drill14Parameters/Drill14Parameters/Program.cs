/*
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1.  Create a class. In that class, create a void method that takes two integers as parameters. 
    Have the method do a math operation on the first integer and display the second integer to the screen.

2. In the Main() method of the console app, instantiate the class.

3. Call the method in the class, passing in two numbers.

4. Call the method in the class, specifying the parameters by name.
This may seem odd, but it is for practice.
*/

using System;

namespace Drill14Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterTest test = new ParameterTest();

            int valueOne = 5;
            int valueTwo = 10;

            //'DoSomething will multiply add 5 + 100 in the background and will write '10' to the console..
            ParameterTest.DoSomething(intOne: valueOne, intTwo: valueTwo);
            Console.ReadLine();
        }
    }
}
