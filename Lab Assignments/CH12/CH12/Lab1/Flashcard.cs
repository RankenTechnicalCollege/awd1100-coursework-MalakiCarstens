using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Flashcard
    {
        private string _term;
        private string _definition;

        public Flashcard(string term, string definition)
        {
            _term = term;
            _definition = definition;
        }
        public string GetTerm()
        {
            return _term;
        }
        public string GetDefinition()
        {
            return _definition;
        }
    }
}
