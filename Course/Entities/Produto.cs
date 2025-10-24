using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Course.Entities
{
    internal class Produto: IComparable
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return Nome + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Produto))
            {
                throw new ArgumentException("Argumento não é um produto");
            }
            Produto other = obj as Produto;
            return Preco.CompareTo(other.Preco);
        }

    }
}
