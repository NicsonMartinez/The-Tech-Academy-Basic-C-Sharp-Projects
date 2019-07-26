using System;

namespace Drill14Parameters
{
    class ParameterTest
    {
        public static void DoSomething(int intOne, int intTwo)
        {
            int totalOne = intOne + 100;
            Console.WriteLine("The second integer you entered is: {0}", intTwo);
        } 
    }
}
