using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DictionaryApp
{
    public abstract class Dictionary
    {
        public abstract void print();
        public abstract void display();

        public static void Main()
        {
            Info.dict();
        }

    }
    class Info
    {
        public static void dict()
        {
            Misc Misce = new Misc();
            Noun Nouns = new Noun();
            Verb Verbs = new Verb();
            Adjective adj = new Adjective();
            Adverb adve = new Adverb();
            NounAndVerb NV = new NounAndVerb();
            ProperNoun PN = new ProperNoun();
            Preposition PR = new Preposition();

            string filePath = @"C:\SampleFile\dictionary.txt";

            int i = 0;
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string word = line;
                i++;

                switch (word)
                {
                    case "misc":
                        //adding word
                        string misc = lines[i - 3];

                        //adding defn
                        string misc1 = lines[i - 2];
                        Misce.getMiscWords(misc, misc1, word);
                        Misce.OnlyMiscWords(misc);
                        break;


                    case "n":
                        //adding word
                        string n = lines[i - 3];

                        //adding defn
                        string n1 = lines[i - 2];
                        Nouns.getNounWords(n, n1, word);
                        Nouns.OnlyNounWords(n);
                        break;


                    case "adj":
                        //adding word
                        string a = lines[i - 3];

                        //adding defn
                        string a1 = lines[i - 2];
                        adj.getAdjWords(a, a1, word);
                        adj.OnlyAdjWords(a);
                        break;


                    case "v":
                        //adding word
                        string vword = lines[i - 3];

                        //adding defn
                        string vdefn = lines[i - 2];
                        Verbs.getVerbWords(vword, vdefn, word);
                        Verbs.OnlyVerbWords(vword);
                        break;

                    case "adv":
                        //adding word
                        string advword = lines[i - 3];

                        //adding defn
                        string advdefn = lines[i - 2];
                        adve.getAdvWords(advword, advdefn, word);
                        adve.OnlyAdvWords(advword);
                        break;

                    case "n_v":
                        //adding word
                        string nvword = lines[i - 3];

                        //adding defn
                        string nvdefn = lines[i - 2];
                        NV.getNVWords(nvword, nvdefn, word);
                        NV.OnlyNVWords(nvword);
                        break;

                    case "pn":
                        //adding word
                        string pnword = lines[i - 3];

                        //adding defn
                        string pndefn = lines[i - 2];
                        PN.getPropNounWords(pnword, pndefn, word);
                        PN.OnlyPropNounWords(pnword);
                        break;

                    case "prep":
                        //adding word
                        string preword = lines[i - 3];

                        //adding defn
                        string predefn = lines[i - 2];
                        PR.getPrepWords(preword, predefn, word);
                        PR.OnlyPrepWords(preword);
                        break;

                }
            }
            int choice;
            int Collectionchoice;
            do
            {
                Console.WriteLine("1. Dictionary");
                Console.WriteLine("2. Word Collection");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Make a choice from 1-3: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("1. Display Miscellaenous Word Dictionary");
                            Console.WriteLine("2. Display Noun Dictionary");
                            Console.WriteLine("3. Display Adjective Dictionary");
                            Console.WriteLine("4. Display Verb Dictionary ");
                            Console.WriteLine("5. Display Adverb Dictionary ");
                            Console.WriteLine("6. Display Noun and Verb Dictionary ");
                            Console.WriteLine("7. Display Proper Noun Dictionary ");
                            Console.WriteLine("8. Display Preposition Dictionary ");
                            Console.WriteLine("9. Exit ");
                            Collectionchoice = Convert.ToInt32(Console.ReadLine());

                            switch (Collectionchoice)
                            {
                                case 1:
                                    Misce.print();
                                    break;
                                case 2:
                                    Nouns.print();
                                    break;
                                case 3:
                                    adj.print();
                                    break;
                                case 4:
                                    Verbs.print();
                                    break;
                                case 5:
                                    adve.print();
                                    break;
                                case 6:
                                    NV.print();
                                    break;
                                case 7:
                                    PN.print();
                                    break;
                                case 8:
                                    PR.print();
                                    break;
                                default:
                                    break;
                            }
                        } while (Collectionchoice != 9);
                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("1. List of Misc Words");
                            Console.WriteLine("2. List of Nouns");
                            Console.WriteLine("3. List of Adjectives");
                            Console.WriteLine("4. List of Verbs");
                            Console.WriteLine("5. List of Adverbs");
                            Console.WriteLine("6. List of Nouns and Verbs");
                            Console.WriteLine("7. List of Proper Nouns ");
                            Console.WriteLine("8. List of Prepositions ");
                            Console.WriteLine("9. Exit ");
                            Collectionchoice = Convert.ToInt32(Console.ReadLine());

                            switch (Collectionchoice)
                            {
                                case 1:
                                    Misce.display();
                                    break;
                                case 2:
                                    Nouns.display();
                                    break;
                                case 3:
                                    adj.display();
                                    break;
                                case 4:
                                    Verbs.display();
                                    break;
                                case 5:
                                    adve.display();
                                    break;
                                case 6:
                                    NV.display();
                                    break;
                                case 7:
                                    PN.display();
                                    break;
                                case 8:
                                    PR.display();
                                    break;
                                default:
                                    break;
                            }
                        } while (Collectionchoice != 9);
                        break;
                }

            } while (choice != 3);

            Console.ReadLine();
        }
      
    }

}
