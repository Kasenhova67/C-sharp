using System;

namespace task3
{
    internal class Program
    {
        public static void Main()
        {
            DateService dateService = new DateService();
            bool v = true;
            while (v)
            {
                
                Console.Write("Введите дату (в формате ГГГГ-ММ-ДД): ");
                string date = Console.ReadLine();
                string dayOfWeek = dateService.GetDay(date);
                Console.WriteLine("День недели: " + dayOfWeek);

                Console.Write("Введите день: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("Введите месяц: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Введите год: ");
                int year = int.Parse(Console.ReadLine());
                int daysSpan = dateService.GetDaysSpan(day, month, year);
                if (daysSpan >= 0)
                {
                    Console.WriteLine("Количество дней: " + daysSpan);
                }
                else
                {
                    Console.WriteLine("Указанная дата больше текущей даты");
                }

                Console.WriteLine(" Что дальше? Введите 0, чтобы выйти, или любую другую цифру, чтобы продолжить ");
                double ans = Convert.ToDouble(Console.ReadLine());
                switch (ans)
                {
                    case 0:
                        v = false;
                        break;
                    default:
                        v = true;
                        break;
                }
            }
        }
    }
}
