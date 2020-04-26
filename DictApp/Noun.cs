using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DictApp
{
    public class Noun : Word
    {
        public Noun(string Words, string Defns,string Types) : base(Words, Defns,Types)
        {
            /*NWord = Words;
            NDefn = Defns;*/
            //Dictionary.WordCollection.Add(Words);
        }
    }
}
