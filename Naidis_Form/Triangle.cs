using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_Form
{
    public class Triangle
    {
        public double a, b, c, ha, hb, hc;

        public Triangle()
        {

        }

        public string outputA(double a) //вывод a
        {
            return Convert.ToString(a);
        }
        public string outputB(double b) //вывод b
        {
            return Convert.ToString(b);
        }
        public string outputC(double c) //вывод c
        {
            return Convert.ToString(c);
        }

        public double Perimeter(double a, double b, double c) // расчитывание периметра
        {
            return a + b + c;
        }
        public double Surface(double a, double b, double c) // расчитывание площади
        {
            double p = Perimeter(a ,b ,c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double SurfaceH(double h, double side) // расчитывание площади
        {
            return 0.5 * side * h;
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
