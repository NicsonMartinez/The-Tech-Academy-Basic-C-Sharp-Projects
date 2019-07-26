using System;
using System.Collections.Generic;
using System.Text;

namespace Drill15Classes
{
    class ComputingStuff
    {
        public int DoSomething(int num)
        {
            num = +100;

            return num;
        }

        public int DoSomething(decimal num)
        {
            num = num * 100;

            int result = Convert.ToInt32(num);

            return result;
        }

        public int DoSomething(string num)
        {
            int result = Convert.ToInt32(num);

            result = result - 100;

            return result;
        }
    }
}
