using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Car
    {
        public int Engine { get; set; }

        public static Car operator + (Car c1, int c2)
        {
            return new Car() { Engine = c1.Engine + c2 };
        }
            
           
    }
}
