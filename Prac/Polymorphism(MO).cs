using System;
using System.Collections.Generic;
using System.Text;

namespace Prac
{
    public class Employee1
    {
        public string FirstName = "CJ";
        public string LastName = "Subhaswini";

        public virtual void PrintFullName1()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee1 : Employee1
    {
        public override void PrintFullName1()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time");
        }
    }

    public class PartTimeEmployee1 : Employee1
    {
        public override void PrintFullName1()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }
    public class Polymorphism_MO_
    {
        public static void Main()
        {
            Employee1[] employees = new Employee1[3];
            employees[0] = new Employee1();
            employees[1] = new FullTimeEmployee1();
            employees[2] = new PartTimeEmployee1();

            foreach (Employee1 e in employees)
            {
                e.PrintFullName1();
            }

        }
    }
}
