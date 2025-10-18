using Course.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services
{
    class ContratoService
    {
        //aqui se equipara ao usecase, recebo a entidade contrato e meu serviço de contrato calcular as parcelas.
        //injeto um serviço de pagamento para o contrato, minha classe recebe qualquer serviço, mas eu vou passar o do paypal

        private IPaymentService _paymentService;

        public ContratoService(IPaymentService ipaymentService)
        {
            _paymentService = ipaymentService;
        }

        public void ProcessarContrato(Contrato contrato, int quantParcelas)
        {
            double valorBaseParcela = contrato.Valor / quantParcelas;
            for(int i = 1;  i <= quantParcelas; i++)
            {
                double valorFinalParcela = _paymentService.CalcularValorDaParcela(valorBaseParcela, i);
                DateOnly dataVencimentoParcela = contrato.Data.AddMonths(i);

                Parcela parcela = new Parcela(dataVencimentoParcela, valorFinalParcela);
                contrato.AdicionarParcelas(parcela);
            }
        }
    }
}
