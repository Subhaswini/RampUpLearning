using System;
using System.Collections.Generic;
using System.Text;
using Prac.ExtMethods;

namespace Prac
{
    public class ExtensionMethods
    {
        public static void Main()
        {
            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine("Result: {0}", result);
        }
    }

    namespace ExtMethods
    {
        public static class IntExtensions
        {
            public static bool IsGreaterThan(this int i, int value)
            {
                return i > value;
            }
        }
    }
}
