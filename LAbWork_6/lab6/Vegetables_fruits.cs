using System;

namespace lab6
{
    internal abstract class Vegetables_fruits
    {
        protected string name;
        protected double price;
        protected bool isHaveVegetables_fruits = false;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public abstract void CreateVegetables_fruits(); // Abstract method

        public virtual void PrintStatus()
        {
            Console.WriteLine("Товары можно забрать");
        }

        public virtual void PrintInformation()
        {
            Console.WriteLine("Товары не выбраны!");
        }

        public Vegetables_fruits()
        {
            Console.WriteLine("\n\nКонструктор родительского класса вызван.\n");
        }
    }
}

