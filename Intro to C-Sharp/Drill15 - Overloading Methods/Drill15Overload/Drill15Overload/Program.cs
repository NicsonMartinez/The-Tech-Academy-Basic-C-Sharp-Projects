/*
EXERCISE:

IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

1. Create a class. In that class, create a method that will take in an integer, do a math operation to it 
and then return the answer as an integer.

2. In the Main() method of the console app, instantiate the class and call the one method, passing in 
an integer, such as 12. Then display the result to the screen.

3. Add a second method to the class, with the same name, that will take in a decimal, do a different math 
operation to it and then return the answer as an integer.

4. In the Main() method of the console app, instantiate the class and call the second method, passing 
in a decimal. Display the result to the screen.

5. Add a third method to the class, with the same name, that will take in a string, convert it to an 
integer if possible, do a different math operation to it and then return the answer as an integer.

6. In the Main() method of the console app, instantiate the class and call the third method, passing 
in a string that equates to an integer. Display the result to the screen.

By: Nicson Martinez
Date: 7/25/19
*/
using System;

namespace Drill15Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputingStuff computingObject = new ComputingStuff();

            int numInput = 12;
            int result = computingObject.DoSomething(numInput);
            Console.WriteLine("Input integer '{0}' + 100 = {1}", numInput, result);

            ComputingStuff computingObject2 = new ComputingStuff();
            decimal decInput = 15.0m;

            int result2 = computingObject2.DoSomething(decInput);
            Console.WriteLine("Input decimal '{0}' * 100 = {1}", decInput, result2);

            ComputingStuff computingObject3 = new ComputingStuff();
            string stringInput = "100";

            int result3 = computingObject3.DoSomething(stringInput);
            Console.WriteLine("Input string '{0}' - 100 = {1}", stringInput, result3);

            Console.ReadLine();

        }
    }
}

