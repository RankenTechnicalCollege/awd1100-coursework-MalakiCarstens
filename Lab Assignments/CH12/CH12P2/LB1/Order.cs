using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Order
    {
        private string _name;
        private Sundae _sundae;
        private Soda _soda;

        public Order()
        {
        }

        public string Name => _name;
        public Soda Soda => _soda;

        public Sundae Sundae => _sundae;

        public double Price
        {
            get
            {
               return _sundae.Price + Soda.Price;
            }
        }

        public Order(string name, bool hasSundae, bool hasSoda)
        {
            _name = name;

            if (hasSundae)
            {
                _sundae = new Sundae();
            }
            if (hasSoda)
            {
                _soda = new Soda();
            }
        }
    }
}
