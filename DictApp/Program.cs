using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DictApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary.LoadWord();
            Console.WriteLine("Main Menu: ");
            Console.WriteLine("1. Definition of a word");
            Console.WriteLine("2. Number of words of each type");
            Console.WriteLine("3. Find Anagrams");
            Console.WriteLine("4. Scrabble Score");
            Console.WriteLine("Make choice from 1-4");
            int choice = Convert.ToInt32(Console.ReadLine());
            string input;
            switch (choice)
            {
                case 1:
                    Dictionary.WordSearch();
                    break;
                case 2:
                    Dictionary.ListCount();
                    break;
                case 3:
                    Console.WriteLine("Enter the word:");
                    input = Console.ReadLine();
                    foreach (var a in Dictionary.FindAnagram(input))
                    {
                        Console.WriteLine($"{a}");
                    }
                    break;
                case 4:
                    break;
                default:
                    break;
            }

        }
        
    }
}
