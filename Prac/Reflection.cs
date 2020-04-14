using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Prac
{
    public class Reflection
    {
        private static void Main()
        {
            /*Gets the type of the customer class. Its important to specify the namespace of the classname as well
            Then the type Te will be able to inspect the other properties once it gets the type of the class using various methods
            //Type Te = Type.GetType("Prac.Customer");*/


            //TypeOf keyword can also be used to get the type of the class
            Type Te = typeof(Customer);

            /* When the customer passes the instance of the class, then this way we can get the type of the class. 
            //Customer C1 = new Customer();
            //Type Te = C1.GetType(); */

            Console.WriteLine("Full Name: {0}", Te.FullName); 
            Console.WriteLine("Name: {0}", Te.Name);
            Console.WriteLine("Namespace: {0}", Te.Namespace);

            //Info about Properties
            Console.WriteLine();
            Console.WriteLine("Properties in Customers");
            //Return type of getproperties is property info array and hence we have stored it in this array
            PropertyInfo[] properties = Te.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);
                Console.WriteLine(property.PropertyType);
            }

            //Info about Methods
            Console.WriteLine();
            Console.WriteLine("Methods in Customer Class");
            MethodInfo[] methods = Te.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
                Console.WriteLine(method.ReturnType);
            }

            //Info about Constructors
            Console.WriteLine();
            Console.WriteLine("Constructors in Customer Class");
            ConstructorInfo[] constructors = Te.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
                Console.WriteLine(constructor.ToString());
                Console.WriteLine(constructor.CustomAttributes);
            }

        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int ID,string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void PrintID()
        {
            Console.WriteLine("ID={0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name={0}", this.Name);
        }

    }
}
