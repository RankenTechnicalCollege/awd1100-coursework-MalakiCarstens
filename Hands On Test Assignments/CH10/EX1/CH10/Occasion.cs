using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    public class Occasion
    {
        public string Name { get; set; }
        public List <Style> Styles { get; set; }

        public Occasion(string name, List<Style> styles)
        {
            Name = name;
            Styles = styles;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
