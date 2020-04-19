using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DictionaryApp
{
    public class Misc : Dictionary, IDisplay
    {
        List<string> miscValues = new List<string>();
        List<string> miscWords = new List<string>();
        public void getMiscWords(string word, string defn, string type)
        {
            miscValues.Add(word);
            miscValues.Add(defn);
            miscValues.Add(type);   
        }
        public void OnlyMiscWords(string word)
        {
            miscWords.Add(word);
            /*miscValues.Add(defn);
            miscValues.Add(type);*/
        }

        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------MISCELLANEOUS DICTIONARY--------------------------------------");
            Console.WriteLine();
            foreach (var x in miscValues)
            {
                Console.WriteLine(x);
            }
        }

        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------MISCELLANEOUS WORDS--------------------------------------");
            Console.WriteLine();
            foreach (var x in miscWords)
            {
                Console.WriteLine(x);
           
            }

        }
    }
}
