using LabWork_5;
using System;
using System.Collections.Generic;

namespace LabWork_5
{
    internal class Client
    {
        public string name;
        private List<AccountType> account_type;
        public Account Account { get; private set; }

        public Client(string name)
        {
            account_type = new List<AccountType>();
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void OpenAccount(AccountType accountType, decimal amount)
        {
            Account = new Account(accountType, amount);
        }
    }
}




