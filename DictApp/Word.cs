﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DictApp
{
    public class Word
    {
        public string _Word { get; set; }
        public string _Definition { get; set; }
        public string _Types { get; set; }
        public Word(string Words, string Defns,string Types)
        {
            _Word = Words;
            _Definition = Defns;
            _Types = Types;
        }

    }
}
