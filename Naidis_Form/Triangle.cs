using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_Form
{
    public class Triangle
    {
        public double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string outputA() //вывод a
        {
            return Convert.ToString(a);
        }
        public string outputB() //вывод b
        {
            return Convert.ToString(b);
        }
        public string outputC() //вывод c
        {
            return Convert.ToString(c);
        }

        public double Perimeter() // расчитывание периметра
        {
            return a + b + c;
        }
        public double Surface() // расчитывание площади
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double GetSetA
        {
            get { return a; }
            set { double a = value; }
        }
        public double GetSetB
        {
            get { return b; }
            set { double b = value; }
        }
        public double GetSetC
        {
            get { return c; }
            set { double c = value; }
        }

        public bool ExistTriangle
        {
            get
            {
                if ((a < b + c) && (b < a + c) && (c < a + b)) // проверяем треугольник
                return true;
                else return false;
            }
        }

    }
}
