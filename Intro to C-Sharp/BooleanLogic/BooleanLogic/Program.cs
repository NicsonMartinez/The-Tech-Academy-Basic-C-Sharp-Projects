using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("true && false: " + (true && false));
            Console.WriteLine("true && true: " + (true && true));
            Console.WriteLine("false && false: " + (false && false));

            Console.WriteLine("\ntrue || true: " + (true || true));
            Console.WriteLine("true || false: " + (true || false));
            Console.WriteLine("false || false: " + (false || false));

            Console.WriteLine("\ntrue == true: " + (true == true));
            Console.WriteLine("true == false: " + (true == false));
            Console.WriteLine("false == false: " + (false == false));

            Console.WriteLine("\ntrue != true: " + (true != true));
            Console.WriteLine("true != false: " + (true != false));
            Console.WriteLine("false != false: " + (false != false));

            //NOTE: If one or the other equals to True but not both.
            //NOTE: If one or the other equals to False but not both.
            // X OR Operator
            Console.WriteLine("\ntrue ^ true: " + (true ^ true));
            Console.WriteLine("true ^ false: " + (true ^ false));
            Console.WriteLine("false ^ false: " + (false ^ false));

            Console.WriteLine("\ntrue && true && true && false: " + (true && true && true && false));
            Console.WriteLine("\ntrue || true || true || false: " + (true || true || true || false));

            Console.ReadLine();


        }
    }
}
