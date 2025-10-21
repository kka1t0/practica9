using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ошибка, радиус должен быть больше 0!");   
                }
                else
                {
                    radius = value;
                }
            }
        }
        public void GerArea()
        {
            double result = Math.PI * (Radius * Radius);
            Console.WriteLine($"Площадь круга: {result}");
        }
    }
}