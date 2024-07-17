using System;
public class CalculationService
{
    public double CalculateFunction(double z, double b)
    {
        double x;
        if (z < 1)
        {
            if (b == 0)
            {
                Console.WriteLine("Невозможно найти ответ, так как вы ввели b = 0.");
            }
            x = z / b;
        }
        else
        {
            if (z * b < 0)
            {
                Console.WriteLine("Невозможно найти ответ, так как вы ввели b<0.");
            }
            x = Math.Sqrt(Math.Pow(z * b, 3));
        }

        double y = -Math.PI + Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) + Math.Pow(Math.Sin(Math.Pow(x, 2)), 3);
        return y;
    }
}

internal class Program
{
    private static double ReadDouble(string str)
    {
        Console.Write(str);
        string input = Console.ReadLine();
        if (double.TryParse(input, out double result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Неправильный ввод. Попробуйте еще раз.");
            return ReadDouble(str);
        }
    }

    static void Main(string[] args)
    {
        CalculationService calculationService = new CalculationService();
        bool v = true;
        while (v)
        {
            double z = ReadDouble("Enter the value of z: ");
            double b = ReadDouble("Enter the value of b: ");

            double result = calculationService.CalculateFunction(z, b);

            Console.WriteLine($"Result of the function calculation: {result}");
            Console.WriteLine($"Branch used: {(z < 1 ? "z<1" : "z>=1")}");
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
