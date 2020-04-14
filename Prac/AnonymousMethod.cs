using System;
using System.Collections.Generic;
using System.Text;

namespace Prac
{
    public delegate string GreetingsDelegate(string name);
    class AnonymousMethod
    {
        //This is the method that is going to be passed to the delegate
        /*  public static string Greetings(string name)
        {
            return "Hello "+ name + " a very good morning!";
        }*/
        public static void Main()
        {
            /*//Normal way of using delegates
            //Here we are actually passing the method which we created earlier
            // GreetingsDelegate del = new GreetingsDelegate(Greetings);*/

            //Anonymous Method
            //Here there is no need to create a method to write the logic but we can just use the delegate keyword and create an instance to call it  
            GreetingsDelegate del = delegate (string name)
            {
                return "Hello " + name + " a very good morning!";
            };

            /* //Lambda Expressions
             //Short hand for writing anonymous functions
             GreetingsDelegate del = (name)=>
             {
                 return "Hello " + name + " a very good morning!";
             };*/

            string str =del.Invoke("CJAY");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
