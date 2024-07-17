using System;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueTheProgram = false;
            do
            {
                Bank bank = Bank.GetInstance();
                Console.Write("Введите наименование банка: ");
                bank.SetBankName(Console.ReadLine());
                Console.Write("Введите число вкладов: ");
                bank.SetNumberOfDeposits(CheckingForInput.Int(Conversion.IntToString(bank.GetNumberOfDeposits())));
                Console.Write("Введите размер вклада: ");
                bank.SetDepositAmount(CheckingForInput.Double(Conversion.DoubleToString(bank.GetDepositAmount())));
                Console.Write("Введите размер процентной ставки: ");
                bank.SetInterestRate(CheckingForInput.Percent(Conversion.IntToString(bank.GetInterestRate())));
                double totalInterest = bank.CalculateTotalInterest();
                Console.WriteLine("\tОбщая выплата по процентам составляет " + totalInterest + ".");
                Console.Write("\nХотите изменить размер вклада? (1 - Да, 2 - Нет): ");
                string str = "\0";
                str = CheckingForInput.ContinuationAndTermination(str);
                switch (str)
                {
                    case "1":
                        Console.Write("\nВведите новый размер вклада: ");
                        double newAmount = CheckingForInput.Double(Conversion.DoubleToString(bank.GetDepositAmount()));
                        bank.ChangeDepositAmount(newAmount);
                        totalInterest =
                            bank.CalculateTotalInterest(); // Пересчитываем общую выплату после изменения размера вклада
                        Console.WriteLine("\tНовая общая выплата по процентам составляет " + totalInterest + ".");
                        break;
                    case "2":
                        break;
                }

                Console.Write("\nХотите продолжить? (1 - Да, 2 - Нет): ");
                str = "\0";
                str = CheckingForInput.ContinuationAndTermination(str);
                switch (str)
                {
                    case "1":
                        continueTheProgram = true;
                        break;
                    case "2":
                        continueTheProgram = false;
                        break;
                }
            } while (continueTheProgram);
        }
    }
}
