using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DictApp
{
    public static class Dictionary
    {

        public static List<Word> WordCollection = new List<Word>();

        public static List<Word> LoadWord()
        {
            string textFile = @"C:\SampleFile\data.txt";
            string line;
            if (File.Exists(textFile))
            {
                StreamReader reader = new StreamReader(textFile);
                while ((line = reader.ReadLine()) != null)
                {
                    string Words = line;
                    string Defns = reader.ReadLine();
                    string Types = reader.ReadLine();
                    reader.ReadLine();

                    switch (Types)
                    {
                        case "misc":
                            Misc misc = new Misc(Words, Defns, Types);
                            WordCollection.Add(misc);
                            /* Type Te = misc.GetType();
                             Console.WriteLine("Type is {0}", Te);*/
                            break;

                        case "n":
                            WordCollection.Add(new Noun(Words, Defns, Types));
                            break;

                        case "adj":
                            WordCollection.Add(new Adjective(Words, Defns, Types));
                            break;

                        case "v":
                            WordCollection.Add(new Verb(Words, Defns, Types));
                            break;

                        case "adv":
                            WordCollection.Add(new Adverb(Words, Defns, Types));
                            break;

                        case "n_v":
                            WordCollection.Add(new NounVerb(Words, Defns, Types));
                            break;

                        case "pn":
                            WordCollection.Add(new ProperNoun(Words, Defns, Types));
                            break;

                        case "prep":
                            WordCollection.Add(new Preposition(Words, Defns, Types));
                            break;
                    }
                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
            return WordCollection;
        }
        public static void WordSearch()
        {
            Console.WriteLine("Enter the word:");
            string input = Console.ReadLine().ToLower();
            var searchedWord = WordCollection.Where(x => x._Word.ToLower().Contains(input));
            foreach (var y in searchedWord)
            {
                Console.WriteLine("Word: {0}", y._Word);
                Console.WriteLine("Type: {0}", y._Types);
                Console.WriteLine("Definition: {0}", y._Definition);
            }
        }
        public static void ListCount()
        {
            Console.WriteLine();
            Console.WriteLine("Number of Words of each type");
            IEnumerable<Word> NounCount = WordCollection.Where(x => x._Types == "n");
            Console.WriteLine("Nouns: {0}", NounCount.Count());
            IEnumerable<Word> VerbCount = WordCollection.Where(x => x._Types == "v");
            Console.WriteLine("Verbs: {0}", VerbCount.Count());
            IEnumerable<Word> MiscCount = WordCollection.Where(x => x._Types == "misc");
            Console.WriteLine("Miscellaneous: {0}", MiscCount.Count());
            IEnumerable<Word> AdvCount = WordCollection.Where(x => x._Types == "adv");
            Console.WriteLine("Adverbs: {0}", AdvCount.Count());
            IEnumerable<Word> AdjCount = WordCollection.Where(x => x._Types == "adj");
            Console.WriteLine("Adjectives: {0}", AdjCount.Count());
            IEnumerable<Word> PnCount = WordCollection.Where(x => x._Types == "pn");
            Console.WriteLine("Proper Nouns: {0}", PnCount.Count());
            IEnumerable<Word> PrepCount = WordCollection.Where(x => x._Types == "prep");
            Console.WriteLine("Prepositions: {0}", PrepCount.Count());
            IEnumerable<Word> NVCount = WordCollection.Where(x => x._Types == "n_v");
            Console.WriteLine("Noun&Verbs: {0}", NVCount.Count());
        }

        public static IEnumerable<string> FindAnagram(string input)
        {
            if (input.Length == 1)
            {
                return new List<string> { input };
            }
            var anagrams = from c in input
                           from a in FindAnagram(new String(input.Where(x => x != c).ToArray()))
                           select c + a;
            return anagrams;
        }
    }
}
