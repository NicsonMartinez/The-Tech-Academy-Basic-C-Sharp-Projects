using System;
using System.Collections.Generic;
using System.Text;

namespace Drill22Generics
{
    //NOTE: Here I am unsing generics in this class and its list property.
    class Employee<T>
    {
        public List<T> Things { get; set; }
    }
}
