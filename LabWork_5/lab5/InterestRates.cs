
namespace LabWork_5;
internal class InterestRates
{
    private Dictionary<AccountType, decimal> rates;
    private List<Client> clients;

    public InterestRates()
    {
        rates = new Dictionary<AccountType, decimal>();
        clients = new List<Client>();
    }

    public void SetRate(AccountType accountType, decimal rate)
    {
        rates[accountType] = rate;
    }

    public decimal GetRate(AccountType accountType)
    {
        return rates.ContainsKey(accountType) ? rates[accountType] : 0;
    }

    public void AddList(Client client)
    {
        clients.Add(client);
    }

    public List<Client> GetClients()
    {
        return clients;
    }
}

