using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryApp
{
    public class Adjective: Dictionary, IDisplay
    {
        List<string> aValues = new List<string>();
        List<string> adjWords = new List<string>();
        public void getAdjWords(string aword, string adefn, string atype)
        {
            aValues.Add(aword);
            aValues.Add(adefn);
            aValues.Add(atype);


        }
        public void OnlyAdjWords(string word)
        {
            adjWords.Add(word);
            /*miscValues.Add(defn);
            miscValues.Add(type);*/


        }

        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------ADJECTIVE DICTIONARY--------------------------------------");
            Console.WriteLine();
            foreach (var x in aValues)
            {
                Console.WriteLine(x);
            }
        }
        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------LIST OF ADJECTIVES--------------------------------------");
            Console.WriteLine();
            foreach (var x in adjWords)
            {
                Console.WriteLine(x);
            }

        }
    }
}
