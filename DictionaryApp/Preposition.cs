﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryApp
{
    class Preposition: Dictionary, IDisplay
    {
        List<string> prValues = new List<string>();
        List<string> prWords = new List<string>();
        public void getPrepWords(string prword, string prdefn, string prtype)
        {
            prValues.Add(prword);
            prValues.Add(prdefn);
            prValues.Add(prtype);


        }
        public void OnlyPrepWords(string word)
        {
            prWords.Add(word);
            /*miscValues.Add(defn);
            miscValues.Add(type);*/


        }

        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------PREPOSITION DICTIONARY--------------------------------------");
            Console.WriteLine();
            foreach (var x in prValues)
            {
                Console.WriteLine(x);
            }
        }

        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------LIST OF PREPOSITIONS--------------------------------------");
            Console.WriteLine();
            foreach (var x in prWords)
            {
                Console.WriteLine(x);
            }

        }
    }
}
