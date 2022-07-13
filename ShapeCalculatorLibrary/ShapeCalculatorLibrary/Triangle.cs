using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatorLibrary
{
    public class Triangle : IGetAreaShape
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double c { get; private set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Ошибка: Стороны треугольника должны быть больше нуля");
            else if (a > (b + c) || b > (a + c) || c > (a + b)) throw new ArgumentException("Ошибка: Одна из сторон не может быть больше суммы двух других сторон");
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
        public bool IsRectangular()
        {
            if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                return true;
            else
                return false;
        }
        public double CalcSquare()
        {
            double HalfPerimeter = (a + b + c) / 2;
            double result = Math.Round(Math.Sqrt(HalfPerimeter * (HalfPerimeter - a) * (HalfPerimeter - b) * (HalfPerimeter - c)), 3);
            return result;
        }


    }
}
