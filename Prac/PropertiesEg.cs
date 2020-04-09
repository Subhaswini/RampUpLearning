using System;
using System.Collections.Generic;
using System.Text;

namespace Prac
{
    class Person
    {
        private int id;
        private string fname;
        private int group = 1;
        
        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public string FName
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this.fname = value;
            }
            get
            {
                return string.IsNullOrEmpty(this.fname)?"No Name": this.fname;
            }
           
        }
        public int Group
        {
            get
            {
                return this.group;
            }
        }
     

    }
    class PropertiesEg
    {
        static void Main(string[] args)
        {
            Person P = new Person();
            P.Id = 100;
            P.FName = "CJ";

            Console.WriteLine("Student id={0}",P.Id);
            Console.WriteLine("Student Fname={0}", P.FName);
            Console.WriteLine("Student group={0}", P.Group);
        }
    }
}
