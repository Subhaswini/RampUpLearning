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

namespace DictApp
{
    public static class Dictionary
    {

        public static List<Word> WordCollection = new List<Word>();
        
        public static List<Word> LoadWord()
        {
            string textFile = @"C:\SampleFile\dictionary.txt";
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
                        WordCollection.Add(new Noun(Words, Defns,Types));
                        break;


                    case "adj":
                        WordCollection.Add(new Adjective(Words, Defns,Types));
                        break;

                    case "v":
                        WordCollection.Add(new Verb(Words, Defns,Types));
                        break;

                    case "adv":
                        WordCollection.Add(new Adverb(Words, Defns,Types));
                        break;

                    case "n_v":
                        WordCollection.Add(new NounVerb(Words, Defns,Types));
                        break;

                    case "pn":
                        WordCollection.Add(new ProperNoun(Words, Defns,Types));
                        break;

                    case "prep":
                        WordCollection.Add(new Preposition(Words, Defns,Types));
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
        public static void SearchbyWordLambda()
        {
            Console.WriteLine("Enter the word:");
            string input = Console.ReadLine();
            var searchedWord = WordCollection.Where(x => x._Word == input);
            foreach (var y in searchedWord)
            {
                Console.WriteLine("Type: {0}", y._Types);
                Console.WriteLine("Definition: {0}", y._Definition);
            }
            //Using IEnumerable<>
/*            IEnumerable<Word> Def = Dictionary.LoadWord().Where(s => s._Word == input);
            foreach (var y in Def)
            {
                Console.WriteLine("Type: {0}", y._Types);
                Console.WriteLine("Definition: {0}", y._Definition);
            }
           */
        }
        public static void SearchByWordLINQ()
        {
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();
            //To get definition
            /*IEnumerable<Word> typ = from w in Dictionary.LoadWord()
                                                where w._Word == input
                                                select w._Definition;*/
            var typ = from w in WordCollection
                      where w._Word == input
                      select w._Types;

            foreach (var z in typ)
            {
                Console.WriteLine("Type: {0}", z);
            }
        }
        public static void SearchByTypeLINQ()
        {
            Console.WriteLine("Enter the type:");
            string input = Console.ReadLine();
            var wor = from w in WordCollection
                      where w._Types == input
                      select w._Word;
            Console.WriteLine($"List of {input} in the dictionary:");
            foreach (var y in wor)
            {
                Console.WriteLine(y);
            }
        }
        public static void SearchbyTypeLambda()
        {
            Console.WriteLine("Enter the type:");
            string input = Console.ReadLine();
            var searchedWord = WordCollection.Where(x => x._Types == input);
            Console.WriteLine($"List of {input} in the dictionary:");
            foreach (var y in searchedWord)
            {
                Console.WriteLine(y._Word);
            }
        }
    }
}
