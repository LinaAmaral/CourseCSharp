using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Model
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Color: " + Color + ", Area: " + Area().ToString("F2", CultureInfo.InvariantCulture) + ", Raio: " + Radius;
        }
    }
}

//Como ele herda da classe shape ele tem color. 
//Como Shape implementa a classe abstrata Area, Circle tem que implementar