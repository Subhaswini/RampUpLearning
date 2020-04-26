using System;
using System.IO;

namespace DictApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary.LoadWord();
            int choice;
            Console.WriteLine("Retreiving Data using Lambda Expression");
            Console.WriteLine("1. Search by Word");
            Console.WriteLine("2. Search by Type");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Make a choice from 1-3: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Dictionary.SearchbyWordLambda();
                    break;
                case 2:
                    Dictionary.SearchbyTypeLambda();
                    break;
                default:
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Retreiving Data using LINQ");
            Console.WriteLine("1. Search by Word");
            Console.WriteLine("2. Search by Type");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Make a choice from 1-3: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Dictionary.SearchByWordLINQ();
                    break;
                case 2:
                    Dictionary.SearchByTypeLINQ();
                    break;
                default:
                    break;
            }
        }
    }
}
