using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

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
            string textFile = @"C:\SampleFile\data.txt";
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
                        Misc misc = new Misc(Words, Defns);
                        WordCollection.Add(misc);
                        break;
                            

                    case "n":
                        WordCollection.Add(new Noun(Words, Defns));
                        break;


                    case "adj":
                        WordCollection.Add(new Adjective(Words, Defns));
                        break;

                    case "v":
                        WordCollection.Add(new Verb(Words, Defns));
                        break;

                    case "adv":
                        WordCollection.Add(new Adverb(Words, Defns));
                        break;

                    case "n_v":
                        WordCollection.Add(new NounVerb(Words, Defns));
                        break;

                    case "pn":
                        WordCollection.Add(new ProperNoun(Words, Defns));
                        break;

                    case "prep":
                        WordCollection.Add(new Preposition(Words, Defns));
                        break;
                }
                }
                reader.Close();
            }
            
        }
      /*  public static void print()
        {
            //WordCollection.ForEach(Console.WriteLine);
           *//* foreach (var x in WordCollection)
            {
                Console.WriteLine("{0}",x._Word);
                
                Console.WriteLine("{0}", x._Definition);
                Console.WriteLine();
            }*//*
        }*/
    }
}
