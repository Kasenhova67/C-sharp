
using System;

namespace lab6
{
    internal sealed class Orange : Vegetables_fruits
    {
        private string origin;

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public override void PrintStatus()
        {
            Console.WriteLine("Апельсины можно забрать");
        }

        public override void PrintInformation()
        {
            if (isHaveVegetables_fruits)
            {
                Console.WriteLine("Апельсины (страна + цена): " + Name + ", " + Price + ". Происхождение: " + origin);
            }
            else
            {
                base.PrintInformation();
            }
        }

        public override void CreateVegetables_fruits()
        {
            isHaveVegetables_fruits = true;
            Console.Write("Введите страну производитель апельсинов: ");
            Name = Console.ReadLine();
            Console.Write("Введите цену: ");
            Price = CheckingForInput.Double(Console.ReadLine());
            Console.Write("Введите вид апельсинов: ");
            Origin = Console.ReadLine();
            PrintStatus();
        }

    }
}