using System;

namespace lab3
{
    internal class Program
    {
        public static int Square(int n)
        {
            return n * n;
        }

        public static void Main()
        {
            int result = Square(2) + Square(3) + Square(4);

            Console.WriteLine("Результат выражения 2^2 + 3^2 + 4^2 = " + result);
        }
    }
}









