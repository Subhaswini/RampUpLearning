using System;
using System.Collections.Generic;
using System.Text;

namespace Prac
{
    abstract class AbstractClass
    {
        public abstract void Add(int a, int b);
    }
    
    class Calc: AbstractClass
    {
        public override void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Main()
        {
            Calc c = new Calc();
            c.Add(8,9);
            Console.ReadLine();
        }
    }
}