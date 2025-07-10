using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Sundae
    {
        public const double BASE_PRICE = 4.5;
        public const double TOPPING_PRICE = 0.5;

        private SundaeTopping[] _toppings;
        private int _toppingCount;
        private double _price;


        public int ToppingCount
        {
            get
            {
                return _toppingCount;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public Sundae()
        {
            _toppingCount = 0;
            _price += BASE_PRICE;
            _toppings = new SundaeTopping[2];
            _toppings[0] = SundaeTopping.NONE;
            _toppings[1] = SundaeTopping.NONE;
        }

        public SundaeTopping GetTopping(int index)
        {
            return _toppings[index];
        }

        public void AddTopping(SundaeTopping t)
        {
            _toppings[_toppingsCount] = t;
            _toppingsCount++;
            _price += TOPPING_PRICE;
        }
    }
}
