using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Soda
    {
        public const double BASE_PRICE = 1.75;
        public const double FLAVOR_PRICE = 0.15;

        private SodaFlavor _flavor;
        private double _price;

        public SodaFlavor Flavor
        {
            get
            {
                return _flavor;
            }
        }

        public double Price => _price;

        public Soda()
        {
            _price += BASE_PRICE;
            _flavor = SodaFlavor.NONE;
        }

        public void AddFlavor(SodaFlavor f)
        {
            _flavor = f;
        }
    }
}
