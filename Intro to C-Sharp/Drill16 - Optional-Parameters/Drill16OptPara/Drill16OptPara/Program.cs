/*
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result.

2. In the Main() method of the console app, instantiate the class.

3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.

4. Call the method in the class, passing in the one or two numbers entered.

5. Try various combinations of numbers on the code, including having no second number.

By: Nicson Martinez
Date: 7/26/19
*/

using System;

namespace Drill16OptPara
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE: This is the while loop that keeps everythng running, when the user makes a mistake.
            bool continueToRun = true;
            while (continueToRun)
            {
                //NOTE: Here are the Instructions for the user.
                Console.WriteLine("\nHi User, You are about to use the 'areaOfSquareOrRectangle' method!!\n");

                Console.WriteLine("INSTRUCTIONS:");
                Console.WriteLine("We will ask you to provide us with the length and the width however, keep in mind that");
                Console.WriteLine("you can leave the width blank, and we will assume we are calculating the area of a square");
                Console.WriteLine("since we only need one side to calculate that. (Please enter numbers greater than 0).\n\n");

                CoolMethods method = new CoolMethods();

                Console.WriteLine("Please enter the length:");
                try
                {
                    //NOTE: Here we are asking the user for a Length input.
                    //NOTE: This conversion is the reason for the try-catch, in case the user types unvalid data.
                    int lengthInput = Convert.ToInt32(Console.ReadLine());

                    //NOTE: Here we are disallowing the user to enter a number <= 0.
                    if(lengthInput < 1)
                    {
                        Console.WriteLine("\nERROR: Please enter an integer greater than 0.\n");
                        continueToRun = true;
                    }
                    //NOTE: If this else statement happened that means the user enetered a number greater than zero.
                    else
                    {

                        //NOTE: Here we ask the user for the width.
                        Console.WriteLine("Now, Please enter the width:");
                        string widthStringInput = Convert.ToString(Console.ReadLine());

                        //NOTE: We left the input as a string, because we instructed the user that if they leave the width blank
                        //      that we would assume they want the area of a square (Which only needs one of the sides of the square
                        //      to figure out).
                        if (string.IsNullOrEmpty(widthStringInput))
                        {
                            string shape = "";
                            //NOTE: In this scenario we are using the 'areaOfSquareOrRectangle' in a way that it is not using
                            //      the optional parameter (which is the purpose of this drill).
                            int result = method.areaOfSquareOrRectangle(lengthInput, out shape);
                            //NOTE: We used an 'out parameter', 'shape', in order to be able to inform the user what shape they're
                            //      calculting regarding their inputs.
                            Console.WriteLine("\nThe area of the '{0}' with a length of '{1}' is = {2}", shape, lengthInput, result);
                            Console.ReadLine();

                            //NOTE: The below while loop is used for the user to decide correctly if they wish to restart the
                            //      program or not.
                            bool continueDecision = true;
                            while (continueDecision)
                            {
                                Console.WriteLine("Would you like to continue? (type 'yes' or 'no'):");
                                string decision = Console.ReadLine();
                                if (decision == "yes")
                                {
                                    continueDecision = false;
                                    continueToRun = true;
                                }
                                else if (decision == "no")
                                {
                                    continueDecision = false;
                                    continueToRun = false;
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Srry.. we did not numderstand..");
                                    continueDecision = true;
                                }
                            }
                            

                        }
                        //NOTE: This happens in the case that the user actually enters something in 'widthInput'.
                        else
                        {   
                            try
                            {
                                
                                string shape;
                                //NOTE: This conversion is the reason for the try-catch, in case the user types unvalid data.
                                //      we are fmaking sure the user to provides us with an integer if they do provide somthing to width.
                                int widthInput = Convert.ToInt32(widthStringInput);

                                //NOTE: New we are making sure that the width is greater than 0.
                                if (widthInput < 1)
                                {
                                    Console.WriteLine("\nERROR: Please enter an integer greater than 0.\n");
                                    continueToRun = true;
                                }

                                //Note: IF we get to this else statement, it is because the width is in fact greater than 0
                                else
                                {
                                    //NOTE: Here we are technically checking if the user is referring to a square based on their input.
                                    //      And letting the user know that based on their 'L' and 'W' inputs, an area of a square was calculated.
                                    if (lengthInput == widthInput)
                                    {
                                        //NOTE: Mind that I am still not using the 'optional parameter' to compute the area of the square.
                                        int result = method.areaOfSquareOrRectangle(lengthInput, out shape);
                                        Console.WriteLine("\nThe area of the '{0}' with a length of '{1}' is = {2}", shape, lengthInput, result);
                                        Console.ReadLine();

                                        //NOTE: The below while loop is used for the user to decide correctly if they wish to restart the
                                        //      program or not.
                                        bool continueDecision = true;
                                        while (continueDecision)
                                        {
                                            Console.WriteLine("Would you like to continue? (type 'yes' or 'no'):");
                                            string decision = Console.ReadLine();
                                            if (decision == "yes")
                                            {
                                                continueDecision = false;
                                                continueToRun = true;
                                            }
                                            else if (decision == "no")
                                            {
                                                continueDecision = false;
                                                continueToRun = false;
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Srry.. we did not numderstand..");
                                                continueDecision = true;
                                            }
                                        }
                                    }
                                    //NOTE: If we got inside this else statement, that means the width entered was either 
                                    //      greater or lower than the length but not 0. This means we have a rectangle!! 
                                    else
                                    {
                                        //NOTE: This time, I am using the 'optional parameter' in my 'areaOfSquareOrRectangle' method becuase it 
                                        //      is now needed. We are now changing that width into an int grater than 0.
                                        int result = method.areaOfSquareOrRectangle(lengthInput, out shape, widthInput);
                                        Console.WriteLine("\nThe area of the '{0}' with a length of '{1}' and width of '{2}' is = {3}", shape, lengthInput, widthInput, result);
                                        Console.ReadLine();

                                        //NOTE: Again, the below while loop is used for the user to decide correctly if they wish to restart the
                                        //      program or not.
                                        bool continueDecision = true;
                                        while (continueDecision)
                                        {
                                            Console.WriteLine("Would you like to continue? (type 'yes' or 'no'):");
                                            string decision = Console.ReadLine();
                                            if (decision == "yes")
                                            {
                                                continueDecision = false;
                                                continueToRun = true;
                                            }
                                            else if (decision == "no")
                                            {
                                                continueDecision = false;
                                                continueToRun = false;
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                Console.WriteLine("Srry.. we did not numderstand..");
                                                continueDecision = true;
                                            }
                                        }
                                    }
                                } 
                            }
                            //NOTE: These are the exceptions for the widthInput.
                            catch (FormatException ex)
                            {
                                Console.WriteLine("\nERROR: " + ex.Message);
                                Console.WriteLine("You must enter an integer.\n");
                                continueToRun = true;
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine("\nERROR: " + ex.Message);
                                Console.WriteLine("The min Int32 value you may enter is -2,147,483,648.");
                                Console.WriteLine("The max Int32 value you may enter is 2,147,483,647.");
                                Console.WriteLine("Any integers lower than the min, or highter than the max will not work.\n");
                                continueToRun = true;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("ERROR: Something went wrong, please try again.\n");
                                continueToRun = true;
                            }

                        }
                    } 
                }
                //NOTE: These are the exceptions for the lengthInput.
                catch (FormatException ex)
                {
                    Console.WriteLine("\nERROR: " + ex.Message);
                    Console.WriteLine("You must enter an integer.\n");
                    continueToRun = true;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("\nERROR: " + ex.Message);
                    Console.WriteLine("The min Int32 value you may enter is -2,147,483,648.");
                    Console.WriteLine("The max Int32 value you may enter is 2,147,483,647.");
                    Console.WriteLine("Any integers lower than the min, or highter than the max will not work.\n");
                    continueToRun = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: Something went wrong, please try again.\n");
                    continueToRun = true;
                }

                
            }
        }
    }
}
