
using System;
using System.Collections.Generic;

namespace LabWork_5
{
    internal class Account
    {
        public AccountType Type { get; private set; }
        public decimal Balance { get; private set; }

        public Account(AccountType type, decimal balance)
        {
            Type = type;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
