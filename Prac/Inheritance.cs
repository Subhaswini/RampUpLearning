using System;
using System.Collections.Generic;
using System.Text;

namespace Prac
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;
    }
    public class Inheritance
    {
        public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "CJ";
            FTE.LastName = "Subhaswini";
            FTE.Email = "cjsubbu@gmail.com";
            FTE.YearlySalary = 300000;
            FTE.PrintFullName();
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "A";
            PTE.LastName = "Sharmila";
            PTE.Email = "asharmila@gmail.com";
            PTE.HourlySalary = 350000;
            PTE.PrintFullName();
        }
    }
}
