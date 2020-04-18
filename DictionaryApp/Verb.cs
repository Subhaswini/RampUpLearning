using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryApp
{
    public class Verb: Dictionary
    {
        List<string> vValues = new List<string>();
        List<string> vWords = new List<string>();
        public void getVerbWords(string word, string defn, string type)
        {
            vValues.Add(word);
            vValues.Add(defn);
            vValues.Add(type);


        }
        public void OnlyVerbWords(string word)
        {
            vWords.Add(word);
            /*miscValues.Add(defn);
            miscValues.Add(type);*/


        }


        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------VERB DICTIONARY--------------------------------------");
            Console.WriteLine();
            foreach (var x in vValues)
            {
                Console.WriteLine(x);
            }
        }
        public override void display()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------LIST OF VERBS--------------------------------------");
            Console.WriteLine();
            foreach (var x in vWords)
            {
                Console.WriteLine(x);
            }

        }
    }
}
