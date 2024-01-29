using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Sentence
    {
        string[] words;

        public Sentence(string s)
        {
            words = s.Split(" ");
        }

        public string this[int index]
        {
            get => words[index];
            set => words[index] = value;
        }
    }
}
