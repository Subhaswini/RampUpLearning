using System;
using System.Collections.Generic;
using System.Text;

namespace Prac
{
    public class MethodOverloading
    {
        public static void Main()
        {
            MethodOverloading M = new MethodOverloading();
            M.Add(5, 4);
            M.Add(5.0, 4.0);
            M.Add(5, 5.0);
            M.Add(5, 5, 5);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine("Sum={0}", a + b);
        }
        public void Add(double a, double b)
        {
            Console.WriteLine("Sum1={0}", a + b);
        }

        public void Add(int a, double b)
        {
            Console.WriteLine("Sum2={0}", a + b);
        }

        public void Add(int a, int b,int c)
        {
            Console.WriteLine("Sum3={0}", a + b + c);
        }

    }
}