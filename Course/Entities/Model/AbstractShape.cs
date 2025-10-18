using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Model
{
    abstract class AbstractShape : IShape
    {
        public string Color { get; set; }

        // já que é uma classe abstrata eu implemento de forma abstrata.
        public abstract double Area();
    }
}
