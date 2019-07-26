using System;
using System.Collections.Generic;
using System.Text;

namespace Drill16OptPara
{
    class CoolMethods
    {
        //NOTE: Here I am using an 'out parameter' called 'shape' which is used the let the user know 
        //      which shape we are calculating.
        public int areaOfSquareOrRectangle(int length, out string shape, int width = 0)
        {
            int result = 0;
            shape = "";

            //NOTE: If the user only enters a length, they want the area of a Square (the width will be 
            //      defaulted to 0 cuasing the funnction to only calculate the length to the power of two.
            if (width == 0)
            {
                shape = "square";
                int areaOfSquare = Convert.ToInt32(Math.Pow(length, 2));
                result = areaOfSquare;
            }
            //NOTE: If the user enters length & width higher, both higher than 0 (and not equal to each other),
            //      then they want area of a rectangle.
            else if (width > 0)
            {
                shape = "rectangle";
                int areaOfRectangle = length * width;
                result = areaOfRectangle;
            }

            return result;
        }
    }
}
