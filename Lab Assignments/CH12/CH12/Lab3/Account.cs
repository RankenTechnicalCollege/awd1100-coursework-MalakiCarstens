using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Account
    {
        private string _accountNumber;
        private string _pin;
        private string _name;
        private decimal _balance;

        public Account(string accountNumber, string pin, string name, decimal balance)
        {
            _accountNumber = accountNumber;
            _pin = pin;
            _name = name;
            _balance = balance;
        }
        public string GetAccountNumber() { return _accountNumber; }
        public string GetPin() { return _pin; }
        public string GetName() { return _name; }
        public decimal GetBalance() { return _balance; }
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > _balance)
            {
                return false;
            }

            _balance -= amount;
            return true;
        }
    }
}
