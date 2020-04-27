using System;
using System.Collections.Generic;
using System.Text;

namespace DictApp
{
    public class ProperNoun : Word
    {
        public ProperNoun(string Words, string Defns,string Types) : base(Words, Defns,Types)
        {
            _Word = Words.Substring(0, 1) + Words.Substring(1);
            _Definition = Defns;
            _Types = Types;
        }
    }
}
