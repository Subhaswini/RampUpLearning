using System;
using System.Collections.Generic;
using System.Text;
//creating a delegate
public delegate void TestDelegate(out int Integer);
namespace Prac
{
    class Delegates
    {
        public static void Main()
        {
            /* //multicast delegates
             TestDelegate del1, del2, del3, del4;

             //Each delegate pointing to a different function
             del1 = new TestDelegate(TMethod1);
             del2 = new TestDelegate(TMethod2);
             del3 = new TestDelegate(TMethod3);

             //concatenating it to allow the delegate to point to different functions
             //Use '+' to chain the delegates together and use '-' to remove a delegate from it. 
             //Removing that particular delegate will not let it point to the function anymore
             del4 = del1 + del2 + del3 - del2;
             del4();*/


            //Another way of simple definition and usage of delegate
            TestDelegate del = new TestDelegate(TMethod1);

            //Here we are asking Method2,Method3 to register with the delegate
            del += TMethod2;
            del += TMethod3;
            //Here we have unregistered Method1 from the delegate. 
            //Also, it will execute in the order we are registering.
            del -= TMethod1;
            //del();
            int deloutparametervalue = 0;
            del(out deloutparametervalue);
            Console.WriteLine("OutValue is {0}", deloutparametervalue);
        }
        public static void TMethod1(out int Number)
        {
            Console.WriteLine("Method One is invoked!");
            Number = 1;
        }
        public static void TMethod2(out int Number)
        {
            Console.WriteLine("Method Two is invoked");
            Number = 2;
        }
        public static void TMethod3(out int Number)
        {
            Console.WriteLine("Method Three is invoked");
            Number = 3;
        }
    }
}
