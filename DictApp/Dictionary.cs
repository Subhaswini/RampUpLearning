using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Xml.Serialization;
using System.Security.Cryptography;

namespace DictApp
{
    public static class Dictionary
    {
        public static string Words { get; set; }
        public static string Defns { get; set; }
        public static string Types { get; set; }

        public static List<Word> WordCollection = new List<Word>();
        
        public static void LoadWord()
        {
            string textFile = @"C:\SampleFile\dictionary.txt";
            string line;
            if (File.Exists(textFile))
            {
                StreamReader reader = new StreamReader(textFile);
                while ((line = reader.ReadLine()) != null)
                {
                    Words = line;
                    Defns = reader.ReadLine();
                    Types = reader.ReadLine();
                    reader.ReadLine();

                switch (Types)
                {
                    case "misc":
                        Misc misc = new Misc(Words, Defns, Types);
                        WordCollection.Add(misc);
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
        }
        public static void SearchbyWordLambda()
        {
            //Console.WriteLine("Searching by word using Lambda Expression");
            Console.WriteLine("Enter the word:");
            string input = Console.ReadLine();
            var searchedWord = WordCollection.Where(x => x._Word == input);
            foreach (var y in searchedWord)
            {
                Console.WriteLine("Type: {0}", y._Types);
                Console.WriteLine("Definition: {0}", y._Definition);
            }
        }
        public static void SearchByWordLINQ()
        {
/*            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Searching by word using Linq Query");*/
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();
            //To get definition
            var Def = from w in WordCollection
            where w._Word == input
            select w._Definition;
            foreach (var y in Def)
            {
                Console.WriteLine("Definition: {0}",y);
            }
            //To get Type
            var typ = from w in WordCollection
                    where w._Word == input
                    select w._Types;
            foreach (var z in typ)
            {
                Console.WriteLine("Type: {0}",z);
            }
        }
        public static void SearchByTypeLINQ()
        {
/*            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Searching by type using Linq Query");*/
            Console.WriteLine("Enter the type:");
            string input = Console.ReadLine();
            //To get definition
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
            //Console.WriteLine("Searching by type using Lambda Expression");
            Console.WriteLine("Enter the type:");
            string input = Console.ReadLine();
            var searchedWord = WordCollection.Where(x => x._Types == input);
            Console.WriteLine($"List of {input} in the dictionary:");
            foreach (var y in searchedWord)
            {
                Console.WriteLine( y._Word);
            }
        }
    }
}
