using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Contrato (int numero, DateTime data, double valor)
        {
            Numero = numero;
            Data = data;
            Valor = valor;
        }
    }
}
