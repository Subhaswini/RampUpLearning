using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryApp
{
    public class Noun: Dictionary, IDisplay
    {
        List<string> nValues = new List<string>();
        List<string> nWords = new List<string>();
        public void getNounWords(string nword, string ndefn, string ntype)
        {
            nValues.Add(nword);
            nValues.Add(ndefn);
            nValues.Add(ntype);
        }
        public void OnlyNounWords(string word)
        {
            nWords.Add(word);

        }

        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------NOUN DICTIONARY--------------------------------------");
            Console.WriteLine();
            foreach (var y in nValues)
            {
                Console.WriteLine(y);
            }
        }

        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------LIST OF NOUNS--------------------------------------");
            Console.WriteLine();
            foreach (var x in nWords)
            {
                Console.WriteLine(x);
            }

        }
    }
}
