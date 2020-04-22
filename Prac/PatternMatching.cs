using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Prac
{
   /* class Student5
    {
        public string Name { get; set; } = "Rahul kumar";
    }*/
    class PatternMatching
    {
        public static void Main(string[] args)
        {
            /*Student5 student = new Student5();
            if (student is Student5)
            {
                Console.WriteLine(student.Name);
            }*/

         /*   string[] students = { "Rahul", "John", "Mayank", "Irfan" };
            Console.WriteLine("Array: [" + string.Join(",", students) + "]");
            // Creating local reference  
            ref string student = ref students[3];
            students[0] = "Peter";  // It will change array value at third index  
            Console.WriteLine("Updated array: [" + string.Join(",", students) + "]");*/

            Expression defaultExpression = Expression.Default(typeof(string));
            show(defaultExpression);
        }
        static void show(Expression defaultExpression)
        {
            // Default expression properties and methods  
            Console.WriteLine("Instace:       " + defaultExpression);
            Console.WriteLine("Type:          " + defaultExpression.Type);
            Console.WriteLine("Can reduce:    " + defaultExpression.CanReduce);
            Console.WriteLine("Instance type: " + defaultExpression.GetType());
            Console.WriteLine("Node type:     " + defaultExpression.NodeType);
        }
    }
}