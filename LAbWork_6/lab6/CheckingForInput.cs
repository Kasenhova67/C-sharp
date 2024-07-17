
using System;

namespace lab6
{
    public static class CheckingForInput
    {
        public static int Choice(string input)
        {
            int result;
            while (!int.TryParse(input, out result) || result < 1 || result > 8)
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите число от 1 до 8: ");
                input = Console.ReadLine();
            }
            return result;
        }

        public static double Double(string input)
        {
            double result;
            while (!double.TryParse(input, out result) || result < 0)
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите положительное число: ");
                input = Console.ReadLine();
            }
            return result;
        }

        public static int Int(string input)
        {
            int result;
            while (!int.TryParse(input, out result) || result < 0)
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите положительное целое число: ");
                input = Console.ReadLine();
            }
            return result;
        }
    }
}