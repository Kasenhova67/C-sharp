using System;
namespace lab4
{
    internal class CheckingForInput
    {
        static public string ContinuationAndTermination(string s)
        {
            while (true)
            {
                s = Console.ReadLine();
                if (s == "1" || s == "2")
                {
                    return s;
                }
                else
                {
                    Console.Write("Неправильный ввод! Попробуйте еще раз: ");
                }
            }
        }

        static public int Int(string s)
        {
            int output;
            while (true)
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out output) && output > 0)
                {
                    return output;
                }
                else
                {
                    Console.Write("Неправильный ввод! Попробуй еще раз: ");
                }
            }
        }

        static public double Double(string s)
        {
            double output;
            while (true)
            {
                s = Console.ReadLine();
                if (double.TryParse(s, out output) && output > 0)
                {
                    return output;
                }
                else
                {
                    Console.Write("Неправильный ввод! Попробуй еще раз: ");
                }
            }
        }

        static public int Percent(string s)
        {
            int output;
            while (true)
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out output) && output >= 0 && output <= 100)
                {
                    return output;
                }
                else
                {
                    Console.Write("Неправильный ввод! Попробуй еще раз: ");
                }
            }
        }
    }
}