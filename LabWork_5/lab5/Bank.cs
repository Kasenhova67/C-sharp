using System.Collections.Generic;
namespace LabWork_5
{
    internal class Bank
    {
        private List<Client> clients;
        private List<InterestRates> rates;

        public Bank()
        {
            clients = new List<Client>();
            rates = new List<InterestRates>();
        }

        public void SetInterestRate(AccountType accountType, decimal rate)
        {
          
            InterestRates interestRates = rates.Find(r => r.GetRate(accountType) == rate);

            if (interestRates != null)
            {
                interestRates.SetRate(accountType, rate);
            }
            else
            {
                interestRates = new InterestRates();
                interestRates.SetRate(accountType, rate);
                rates.Add(interestRates);
            }
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public List<Client> Clients
        {
            get { return clients; }
        }

        public decimal CalculateClientInterest(Client client)
        {
            decimal totalInterest = 0;

            InterestRates interestRates = rates.Find(r => r.GetRate(client.Account.Type) != 0);

            if (interestRates != null)
            {
                totalInterest = client.Account.Balance * interestRates.GetRate(client.Account.Type);
            }

            return totalInterest;
        }

        public decimal CalculateTotalInterest(List<Client> clients)
        {
            decimal totalInterest = 0;
            foreach (Client client in clients)
            {
                totalInterest += CalculateClientInterest(client);
            }

            return totalInterest;
        }

        public Client SearchClient(string name)
        {
            foreach (Client client in clients)
            {
                if (client.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return client;
                }
            }

            return null;
        }
    }
}