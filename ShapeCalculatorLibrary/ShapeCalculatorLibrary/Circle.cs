using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatorLibrary
{
    public class Circle : IGetAreaShape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Ошибка: Радиус должен быть больше нуля");
            this.Radius = radius;
        }
        public double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 3);
        }
    }
}
