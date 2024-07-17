namespace lab4
{
    internal class Bank
    {
        // Fields
        private static Bank instance;
        private string bankName;
        private int numberOfDeposits;
        private Deposit deposit;
        private int interestRate;

        // Properties 
        public string GetBankName() => bankName;
        public void SetBankName(string name) => bankName = name;
        public int GetNumberOfDeposits() => numberOfDeposits;
        public void SetNumberOfDeposits(int count) => numberOfDeposits = count;
        public double GetDepositAmount() => deposit.Amount;
        public void SetDepositAmount(double amount) => deposit.Amount = amount;
        public int GetInterestRate() => interestRate;
        public void SetInterestRate(int rate) => interestRate = rate;

        // Methods
        private Bank()
        {
            deposit = new Deposit();
        }
        public static Bank GetInstance()
        {
            if (instance == null)
            {
                instance = new Bank();
            }
            return instance;
        }

        public double CalculateTotalInterest()
        {
            double totalInterest = deposit.Amount * ((double)interestRate / 100) * numberOfDeposits;
            return totalInterest;
        }

        public void ChangeDepositAmount(double newAmount)
        {
            deposit.Amount = newAmount;
        }
    }
}