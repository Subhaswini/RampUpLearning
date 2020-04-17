using System;
using System.Collections.Generic;
using System.Text;

namespace Prac
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    class Interfaces : I1, I2
    {
        //Default implementation
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 interface method");
        }
        //Explicit implementation
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method");
        }
        public static void Main()
        {
            Console.WriteLine("INTERFACE EXAMPLE");
            Interfaces Inter = new Interfaces();
            //Inter.InterfaceMethod();
            //((I1)Inter).InterfaceMethod();

            //Calling the default interface
            Inter.InterfaceMethod();

            //Calling the explicit interface
            ((I2)Inter).InterfaceMethod();
        }

    }
}
