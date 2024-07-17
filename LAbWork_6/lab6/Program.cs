using System;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banana banana = new Banana();
            Orange orange = new Orange();
            Mango mango = new Mango();
            Console.Clear();

            Menu menuLab = new Menu("6", "1", "15", "Изучить механизмы наследования в C#. Индивидуальное задание: овощи и фрукты", "Гусенцова Екатерина", "353504");
            menuLab.ShowInfo();
            Console.WriteLine("Добро пожаловать в магазин овощей и фруктов!\n");

            bool ans = true;
            while (ans)
            {
                Menu.MainMenu();
                Console.Write("\nВыбор: ");
                int choice = CheckingForInput.Choice(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        banana.CreateVegetables_fruits();
                        break;
                    case 2:
                        mango.CreateVegetables_fruits();
                        break;
                    case 3:
                        orange.CreateVegetables_fruits();
                        break;
                    case 4:
                        banana.PrintInformation();
                        break;
                    case 5:
                        mango.PrintInformation();
                        break;
                    case 6:
                        orange.PrintInformation();
                        break;
                    case 7:
                        Banana newBanana = new Banana();
                        newBanana.CreateVegetables_fruits();
                        break;
                    case 8:
                        ans = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                        break;
                }
            }
        }
    }
}
