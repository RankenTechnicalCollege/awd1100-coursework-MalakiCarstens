using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    public class Style
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Image Image { get; set; }

        public Style(string name, decimal price, Image image)
        {
            Name = name;
            Price = price;
            Image = image;
        }
        public override string ToString()
        {
            return $"Cost: ${Price:f2}";
        }
    }
}
