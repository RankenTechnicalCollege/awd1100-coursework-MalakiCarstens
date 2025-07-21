using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    public class ShortTermLoan : ILoan
    {
        const double INTEREST_RATE = 0.10;
        const double PAYMENT_AMOUNT = 450;
        public string _name;
        public string _type;
        public double _balance;
        public ShortTermLoan(string name, string type, double balance)
        {
            _name = name;
            _type = type;
            _balance = balance;
        }
        public string Name { get { return _name; } }
        public string Type { get { return _type; } }
        public double Balance { get { return _balance; } }

        public void MakePayment()
        {
            _balance -= PAYMENT_AMOUNT;
            if (_balance < 0) _balance = 0;
        }
        public void ApplyInterest()
        {
            _balance *= (1 + INTEREST_RATE);
        }
    }
}
