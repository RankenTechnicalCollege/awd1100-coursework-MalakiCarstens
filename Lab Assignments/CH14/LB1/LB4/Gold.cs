using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Gold : Account
    {
        public Gold(string accountNum, string pin, double balance) : base(accountNum, pin, balance)
        {

        }
        public override double MinimumBalance()
        {
            return 5000;
        }
        public override double TransactionFee()
        {
            return 0;
        }

    }
}
