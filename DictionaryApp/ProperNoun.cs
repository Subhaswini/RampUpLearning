using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DictionaryApp
{
    public class ProperNoun: Dictionary, IDisplay
    {
        List<string> pnValues = new List<string>();
        List<string> pnWords = new List<string>();
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
        public void getPropNounWords(string ponword, string pondefn, string pontype)
        {
            pnValues.Add(ponword);
            pnValues.Add(pondefn);
            pnValues.Add(pontype);
            //Converting to titlecase
            CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            pnValues = pnValues.ConvertAll(r => currentCulture.TextInfo.ToTitleCase(r.ToLower()));

        }
        public void OnlyPropNounWords(string word)
        {
            pnWords.Add(word);
            CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            pnWords = pnWords.ConvertAll(r => currentCulture.TextInfo.ToTitleCase(r.ToLower()));
            /*miscValues.Add(defn);
            miscValues.Add(type);*/
        }

        public override void print()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------PROPER NOUN DICTIONARY--------------------------------------");
            Console.WriteLine();
            foreach (var x in pnValues)
            {
                Console.WriteLine(x);
            }
        }
        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------LIST OF PROPER NOUNS--------------------------------------");
            Console.WriteLine();
            foreach (var x in pnWords)
            {

                /*CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                pnWords = pnWords.ConvertAll(r => currentCulture.TextInfo.ToTitleCase(r.ToLower()));*/
                //Console.WriteLine(x, myTI.ToTitleCase(x));
                Console.WriteLine(x);
            }

        }
    }
}
