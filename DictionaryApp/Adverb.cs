using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryApp
{
    public class Adverb: Dictionary
    {
        List<string> advValues = new List<string>();
        List<string> advWords = new List<string>();
        public void getAdvWords(string adword, string addefn, string adtype)
        {
            advValues.Add(adword);
            advValues.Add(addefn);
            advValues.Add(adtype);


        }
        public void OnlyAdvWords(string word)
        {
            advWords.Add(word);
            /*miscValues.Add(defn);
            miscValues.Add(type);*/


        }

        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------ADVERB DICTIONARY--------------------------------------");
            Console.WriteLine();
            foreach (var x in advValues)
            {
                Console.WriteLine(x);
            }
        }

        public override void display()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------LIST OF ADVERBS--------------------------------------");
            Console.WriteLine();
            foreach (var x in advWords)
            {
                Console.WriteLine(x);
            }

        }
    }
}
