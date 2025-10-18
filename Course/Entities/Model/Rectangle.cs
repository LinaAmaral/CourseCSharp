using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Model
{
    class Rectangle : Shape
    {
        public double Altura { get; set; }
        public double Largula { get; set; }
        public override double Area()
        {
            return Altura * Largula;
        }

        public override string ToString()
        {
            return "Color: " + Color + ", Area: " + Area().ToString("F2", CultureInfo.InvariantCulture) + ", Altura: " + Altura + ", Largura: " + Largula;
        }
    }
}
