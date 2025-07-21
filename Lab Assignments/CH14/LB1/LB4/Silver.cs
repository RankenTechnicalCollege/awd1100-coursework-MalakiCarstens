using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Silver : Account
    {
        public Silver(string accountNum, string pin, double balance) : base(accountNum, pin, balance)
        {
            return;
        }
        public override double MinimumBalance()
        {
            return 1000;
        }
    }
}
