
using System.Globalization;

namespace Course.Entities
{
    class Parcela
    {
        public DateOnly DataPagamento { get; set; }
        public double ValorParcela { get; set; }

        public Parcela(DateOnly dataPagamento, double valorParcela)
        {
            DataPagamento = dataPagamento;
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return DataPagamento.ToString("dd/MM/yyyy") + " - " + ValorParcela.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
