using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prac
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> student = new List<Student>();
            Student student1 = new Student { ID = 101, Name = "Irfan", Email = "irfan@gmail.com" };
            Student student2 = new Student { ID = 102, Name = "Rahul", Email = "rahul@abc.com" };
            Student student3 = new Student { ID = 103, Name = "John", Email = "john@abc.com" };
            student.Add(student1);
            student.Add(student2);
            student.Add(student3);
            return student;
        }
    }
    class QueryExpressions
    {
        static void Main(string[] args)
        {
            IEnumerable<string> queryName =
                from student in Student.GetStudents()
                where student.ID == 103
                select student.Name;
            foreach (var s in queryName)
                Console.Write(s);
        }
    }
}