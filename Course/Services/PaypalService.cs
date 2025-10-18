using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    class PaypalService : IPaymentService
    {
        private const double JurosMensal = 0.01;
        private double TaxaDePagamento = 0.02;

        public double CalcularJurosSimplesMensal(double valorParcela, int numParcela)
        {
            return valorParcela * JurosMensal * numParcela;
        }

        public double CalcularTaxaPagamento(double valorParcela)
        {
            return valorParcela * TaxaDePagamento;
        }
        
        //simplificando em um único método
        public double CalcularValorDaParcela(double valorBaseParcela, int numParcela)
        {
            return (valorBaseParcela * (1 + JurosMensal * numParcela)) * (1 + TaxaDePagamento);
        }

      
    }
}
