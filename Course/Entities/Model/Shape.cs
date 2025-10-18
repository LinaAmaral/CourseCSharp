using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Model
{
    abstract class Shape
    {
        public string Color { get; set; }
        public abstract double Area();
    }
}
