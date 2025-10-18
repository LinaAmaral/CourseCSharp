

namespace Course.Services
{
    interface IPaymentService
    {
        double CalcularJurosSimplesMensal(double valorParcela, int numParcela);
        double CalcularTaxaPagamento(double taxa);

        double CalcularValorDaParcela(double valorBaseParcela, int numParcela);

    }
}
