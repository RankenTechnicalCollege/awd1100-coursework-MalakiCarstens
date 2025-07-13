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
               double price = 0;
                if (_soda == null)
                {
                    price = _sundae.Price;
                }
                else if(_sundae == null)
                {
                    price = _soda.Price;
                }
                else
                {
                    price = Sundae.Price + _soda.Price;
                }
                return price;

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
