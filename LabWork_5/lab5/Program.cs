using System;

using System.Collections.Generic;
namespace LabWork_5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.SetInterestRate(AccountType.Savings, 0.03m);
            bank.SetInterestRate(AccountType.FixedDeposit, 0.05m);
            bank.SetInterestRate(AccountType.RecurringDeposit, 0.04m);

            Client client1 = new Client("Alice");
            client1.OpenAccount(AccountType.Savings, 1000);
            bank.AddClient(client1);

            Client client2 = new Client("Bob");
            client2.OpenAccount(AccountType.FixedDeposit, 2000);
            bank.AddClient(client2);

            decimal client1Interest = bank.CalculateClientInterest(client1);
            Console.WriteLine("Клиент " + client1.Name);
            Console.WriteLine("Тип счета: " + client1.Account.Type);
            Console.WriteLine("Процент: " + client1Interest);

            decimal client2Interest = bank.CalculateClientInterest(client2);
            Console.WriteLine("Клиент " + client2.Name);
            Console.WriteLine("Тип счета: " + client2.Account.Type);
            Console.WriteLine("Процент: " + client2Interest);

            decimal totalInterest = bank.CalculateTotalInterest(bank.Clients);
            Console.WriteLine("Общая сумма выплат по процентам: " + totalInterest);

            Console.WriteLine("Введите имя клиента для поиска в списке:");
            string searchName = Console.ReadLine();
            Client findClient = bank.SearchClient(searchName);
            if (findClient != null)
            {
                Console.WriteLine("Клиент " + findClient.Name);
                Console.WriteLine("Тип счета: " + findClient.Account.Type);
                Console.WriteLine("Процент: " + bank.CalculateClientInterest(findClient));
            }
            else
            {
                Console.WriteLine("Клиент не найден!");
            }

            Console.WriteLine("\n\n");
        }
    }
}
