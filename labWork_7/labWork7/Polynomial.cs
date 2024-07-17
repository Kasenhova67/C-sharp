using System;

namespace lab7
{
    internal class Polynomial
    {
        private int a;
        private int b;
        private int c;

        public Polynomial(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }
        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public override string ToString()
        {
            return ("Polynomial = (" + a + "x + " + b + "y + " + c + "z)");
        }

        public int this[int index]
        {
            get
            {
                if (index == 0) return a;
                else if (index == 1) return b;
                else if (index == 2) return c;
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (index == 0) a = value;
                else if (index == 1) b = value;
                else if (index == 2) c = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            return new Polynomial(p1.a + p2.a, p1.b + p2.b, p1.c + p2.c);
        }

        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            return new Polynomial(p1.a - p2.a, p1.b - p2.b, p1.c - p2.c);
        }

        public static Polynomial operator *(Polynomial p, int number)
        {
            return new Polynomial(p.a * number, p.b * number, p.c * number);
        }

        public static Polynomial operator /(Polynomial p, int number)
        {
            if (number == 0)
            {
                throw new DivideByZeroException();
            }
            return new Polynomial(p.a / number, p.b / number, p.c / number);
        }

        public static Polynomial operator ++(Polynomial p)
        {
            return new Polynomial(p.a + 1, p.b + 1, p.c + 1);
        }

        public static Polynomial operator --(Polynomial p)
        {
            return new Polynomial(p.a - 1, p.b - 1, p.c - 1);
        }

        public static bool operator ==(Polynomial p1, Polynomial p2)
        {
            return (p1.a == p2.a && p1.b == p2.b && p1.c == p2.c);
        }

        public static bool operator !=(Polynomial p1, Polynomial p2)
        {
            return !(p1 == p2);
        }

        public static bool operator true(Polynomial p)
        {
            return !(p.a == 0 && p.b == 0 && p.c == 0);
        }

        public static bool operator false(Polynomial p)
        {
            return (p.a == 0 && p.b == 0 && p.c == 0);
        }

        public static explicit operator int(Polynomial p)
        {
            return p.a+p.b+p.c;
        }

        public static explicit operator Polynomial(int number)
        {
            return new Polynomial(number, number, number);
        }
    }
}