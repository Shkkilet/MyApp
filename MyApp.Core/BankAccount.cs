using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Core
{
    public class BankAccount
    {
        private decimal balance;
        public string Owner { get; private set; }
        public decimal Balance => balance;
        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            balance -= amount;
        }
        private void RecalculateInterest() { }
    }
}
