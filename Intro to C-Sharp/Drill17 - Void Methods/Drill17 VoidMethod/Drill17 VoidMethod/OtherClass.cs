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
using System.Collections.Generic;
using System.Text;

namespace Drill17_VoidMethod
{
    class OtherClass
    {
        //Number 1
        public void DivideBy2(int num)
        {
            int result = num / 2;
            Console.WriteLine(result);
        }

        //Number 4 & 5
        public void DivideBy2(int num, out int result)
        {
            result = num / 2;
        }
    }
}
