using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //NOTE: This is how you say, here I a have an int array called numArray.
            //int[] numArray;

            //NOTE: But to actually CREATE an array, you have to actually instantiate it, because arrays are objects.
            //NOTE: SO essentially we have to c reate a new array of it.

            //NOTE: when you write 'int[] nunmArray = new int[];' it will not compile.
            //NOTE: it will say 'Array creation must have array size or array initializer.'
            //NOTE: in C#, an array is expected to have a fixed size as shown below.
            int[] numArray = new int[5];

            //NOTE: now we are adding the five integers this 'numArray' object can hold.
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            Console.WriteLine("numArray[3]: " + numArray[3]);

            //NOTE: There is a diffent way we can add numbers to an array object and set the length all in one line.
            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            Console.WriteLine("numArray1[3]: " + numArray1[3]);

            //NOTE: There is even a FASTER way of creating an array and adding values to it in C# as shown below.
            int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            Console.WriteLine("numArray2[3]: " + numArray2[3]);

            //NOTE: To change a value in an array (in its sixth position.
            numArray2[5] = 650;
            Console.WriteLine("numArray2[5]: " + numArray2[5]);

            //----------------------------------------------------------------------------------------------------------------------------

            //NOTE: Now after going over 'arrays', we will learn about 'lists' in C#. Lists were introduced in C# 2.0 and they are
            //very similar to an array, but 'using System.Collections.Generic;' needs to be used in order to create lists. They're
            //called 'Generics' because you can create a list with any datatype, similar to an array but in a different namespace.

            //NOTE: Note how we didn't have to give it a length in order to create the list object below.
            //Lists are much more adaptable and there are a lot more methods connected to them than arrays.
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            intList.Remove(10);

            Console.WriteLine("intList[0]: " + intList[0]);

            //NOTE: Example of storing strings.
            List<string> intList1 = new List<string>();
            intList1.Add("Hello");
            intList1.Add("Nicson");
            intList1.Remove("Nicson");

            Console.WriteLine("intList1[0]: " + intList1[0]);
            Console.ReadLine();


            //NOTE: Ideally you will use an array when you have a fixed quantity of things. Or when you have a very large quantity of things.





        }
    }
}
