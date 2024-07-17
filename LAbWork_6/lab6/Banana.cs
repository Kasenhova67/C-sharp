using System;

namespace lab6
{
    internal class Banana : Vegetables_fruits
    {
        protected int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Бананы можно забрать");
        }

        public void Number()
        {
            Console.WriteLine("Количество бананов: " + count);
        }

        public override void CreateVegetables_fruits()
        {
            isHaveVegetables_fruits = true;
            Console.Write("Введите страну производитель: ");
            Name = Console.ReadLine();
            Console.Write("Введите цену бананов: ");
            Price = CheckingForInput.Double(Console.ReadLine());
            Console.Write("Введите количество: ");
            Count = CheckingForInput.Int(Console.ReadLine());
            PrintStatus();
        }

        public override void PrintInformation()
        {
            if (isHaveVegetables_fruits)
            {
                Console.WriteLine("Бананы (страна + цена): " + Name + ", " + Price + ". ");
                Number();
            }
            else
            {
                base.PrintInformation();
            }
        }

        public Banana()
        {
            Console.WriteLine("Конструктор производного класса Banana вызван!\n\n");
        }
    }
}