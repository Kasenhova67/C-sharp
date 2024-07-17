using System;

namespace lab6
{
    internal class Mango : Vegetables_fruits
    {
        protected int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Манго можно забрать");
        }

        public void Number()
        {
            Console.WriteLine("Количество: " + count);
        }

        public override void CreateVegetables_fruits()
        {
            isHaveVegetables_fruits = true;
            Console.Write("Введите страну производитель манго: ");
            Name = Console.ReadLine();
            Console.Write("Введите цену манго: ");
            Price = CheckingForInput.Double(Console.ReadLine());
            Console.Write("Введите количество: ");
            Count = CheckingForInput.Int(Console.ReadLine());
            PrintStatus();
        }

        public override void PrintInformation()
        {
            if (isHaveVegetables_fruits)
            {
                Console.WriteLine("Манго (страна + цена): " + Name + ", " + Price + ". ");
                Number();
            }
            else
            {
                base.PrintInformation();
            }
        }
    }
}
