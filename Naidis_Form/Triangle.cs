using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_Form
{
    public class Triangle
    {
        public double a, b, c, h, side;

        public Triangle(double a, double b, double c)
        {
            a= 0;
            b= 0;
            c= 0;

        }

        public string OutputA(double a) //вывод a
        {
            return Convert.ToString(a);
        }
        public string OutputB(double b) //вывод b
        {
            return Convert.ToString(b);
        }
        public string OutputC(double c) //вывод c
        {
            return Convert.ToString(c);
        }
        public string OutputH(double h) //вывод h
        {
            return Convert.ToString(h);
        }


        public double Perimeter(double a, double b, double c) // расчитывание периметра
        {
            if (a != 0 && b != 0 && c != 0 ) { return a + b + c; }
            else { return 0; };
        }
        public double Height(double a, double b, double c) // расчитывание высоты
        {
            double p = Perimeter(a, b, c);
            p /= 2;
            double max = Math.Max(a, Math.Max(b, c));
            return (2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c))) / max;
        }
        public double Surface(double a, double b, double c) // расчитывание площади
        {
            double p = Perimeter(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double SurfaceH(double h, double side) // расчитывание полщади по высоте
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

        public bool ExistTriangle(double a, double b, double c)
        {

            if ((a < b + c) && (b < a + c) && (c < a + b)) // проверяем треугольник
            { return true; }
            else { return false; }
        }

    }
}
