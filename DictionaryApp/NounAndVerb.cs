using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryApp
{
    public class NounAndVerb: Dictionary
    {
        List<string> nvValues = new List<string>();
        List<string> nvWords = new List<string>();
        public void getNVWords(string navword, string navdefn, string navtype)
        {
            nvValues.Add(navword);
            nvValues.Add(navdefn);
            nvValues.Add(navtype);


        }
        public void OnlyNVWords(string word)
        {
            nvWords.Add(word);
            /*miscValues.Add(defn);
            miscValues.Add(type);*/


        }

        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------NOUN AND VERB DICTIONARY--------------------------------------");
            Console.WriteLine();
            foreach (var x in nvValues)
            {
                Console.WriteLine(x);
            }
        }
        public override void display()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------LIST OF NOUNS AND VERBS--------------------------------------");
            Console.WriteLine();
            foreach (var x in nvWords)
            {
                Console.WriteLine(x);
            }

        }
    }
}
