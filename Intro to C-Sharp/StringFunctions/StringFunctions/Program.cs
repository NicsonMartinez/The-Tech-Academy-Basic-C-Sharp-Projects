using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nicson";

            //NOTE: These are 'Scape-Sequences.'
            //NOTE: The back-slash can be used as an 'escape key' so that we can use double-quotes inside a tring.
            //NOTE: '\n' is new line and '\t' is for tab.
            string quote = "The man said, \"Hello\", Nicson. \n Hello on a new line. \n \t Hello on a tab.";

            //NOTE: Scape sequences must be used in file directory lines so that the computer doesn't get confused 
            //with scape sequences.
            string fileName = "C:\\Users\\Nicson";

            //NOTE: In C# there is a way to tell the compiler that there are no scape sequences in the string and the that
            //the string is as it is. that is by adding the '@' in front and attached with the string. 
            string fileName2 = @"C:\Users\Nicson";

            //NOTE: You can use different built in functions (for strings) which can help you determine different things happening in a string.
            bool trueOrFalse = name.Contains("s"); //NOTE: This will equal to 'true'.
            trueOrFalse = name.EndsWith("s"); //NOTE: This will equal to 'false'.

            //NOTE: Gets the character length of an iterable object such as a string.
            int length = name.Length;

            //NOTE: Other built in functions one can use are 'ToUpper' for upper casing all and 'ToLower' lower casing all.
            string AllUpperCaseName = name.ToUpper();
            string AllLowerCaseName = name.ToLower();

            //NOTE: In C#, Strings are immutable (can't be changed). That means that whenever we assign a variable with a string, and then reassign it 
            //a different string afterwards, even though it looks like we changed the value, in reality, in memory a new string with the same variable 
            //name was created. Meaning that if we reassign a new string to object multiple times eventually it will start taking up a lot of space in 
            //memory causing processing to slow down.
            string myString1 = "The String";
            myString1 = "Joe";

            //NOTE: 

            //NOTE: In order to not use as much memeory and accomplish this talk without losing performance is by creating an instance of a an integrated 
            //class, StringBuilder().
            //NOTE: I must keep in mind that 'using System.Text;' must be written at the top of the code in order to use the 'SrtingBuilder' class.
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
