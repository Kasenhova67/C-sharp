using lab7;

internal class Program
{
    static void Main(string[] args)
    {
        Polynomial poly1 = new Polynomial(5, 9, 3);
        Polynomial poly2 = new Polynomial(1, 1, 1);

        Console.WriteLine(poly1.ToString());
        Console.WriteLine(poly2.ToString() + "\n");

        Polynomial sum = poly1 + poly2;
        Console.WriteLine("Сумма: " + sum);
        Polynomial difference = poly1 - poly2;
        Console.WriteLine("Разность: " + difference + "\n");

        Polynomial multiplication1 = poly1 * 2;
        Console.WriteLine("Умножение полинома на число: " + multiplication1);
        Polynomial delenie = poly1 / (-4);
        Console.WriteLine("Деление полинома на число(остается лишь целая часть): " + delenie + "\n");
        Polynomial increment = ++poly1;
        Console.WriteLine("Инкремент: " + increment);
        Polynomial decrement = --poly2;
        Console.WriteLine("Декремент: " + decrement + "\n");

        bool equal = poly1 == poly2;
        Console.WriteLine("Сравнение(==): " + equal);
        bool doesNotEqual = poly1 != poly2;
        Console.WriteLine("Сравнение(!=): " + doesNotEqual + "\n");

        if (poly1)
        {
            Console.WriteLine("Polynomial не равен (0,0,0).");
        }
        else
        {
            Console.WriteLine("Polynomial равен (0,0,0).");
        }

        if (poly2)
        {
            Console.WriteLine("Polynomial не равен (0,0,0).");
        }
        else
        {
            Console.WriteLine("Polynomial равен (0,0,0).");
        }

        int convertToInt = (int)poly1;
        Console.WriteLine("\nПреобразование в int: " + convertToInt);
        Polynomial convertToPolynomialFromInt = (Polynomial)12;
        Console.WriteLine("Преобразование в Polynomial: " + convertToPolynomialFromInt + "\n");
    }
}