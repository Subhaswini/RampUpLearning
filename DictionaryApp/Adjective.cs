using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryApp
{
    public class Adjective: Dictionary
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

        public void printadj()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------ADJECTIVE DICTIONARY--------------------------------------");
            Console.WriteLine();
            foreach (var x in aValues)
            {
                Console.WriteLine(x);
            }
        }
        public void displayadj()
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
