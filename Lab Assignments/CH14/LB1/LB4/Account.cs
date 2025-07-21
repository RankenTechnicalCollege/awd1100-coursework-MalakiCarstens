using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Account
    {
       public List<string> Transactions = new List<string>();
        public string _accountNum;
        public string _pin;
        public double _balance;
        public Account(string account, string pin, double balance)
        {
            _accountNum = account;
            _pin = pin;
            _balance = balance;
        }
        public string GetAccount { get { return _accountNum; } }
        public string GetPin { get { return _pin; } }
        public double GetBalance() { return _balance; }
         public virtual double MinimumBalance()
        {
            return 0;
        }
        public virtual double TransactionFee()
        {
            return 0.01;
        }
        public virtual void Deposit(double amount)
        {
            _balance += amount;
            Transactions.Add($"{amount:C}");
            if (Transactions.Count > 10)
            {
                Transactions.RemoveAt(0);
            }
            
        }
        public virtual void Withdraw(double amount)
        {
            double fee = amount * TransactionFee();
            double total = amount + fee;
            if (_balance - total >= MinimumBalance())
            {
                _balance -= total;
                Transactions.Add($"Withdrew: {amount:C} Fee: {fee:C}");
                return;
            }
        }
        public virtual string GetStatement()
        {
            return $"{GetBalance():C}";
        }

    }
}
