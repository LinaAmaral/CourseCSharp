
namespace Course.Entities
{
    class ContribuintePessoaJuridica : Contribuinte
    {
        double ALICOTA_PADRAO = 0.16;
        double ALICOTA_REDUZIDA = 0.14;
        double QUANT_FUNCIONARIO_ALICOTA_REDUZIDA = 10;
        public int NumeroFuncionarios { get; set; }
        public ContribuintePessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double ImpostoAPagar()
        {
            double alicota = NumeroFuncionarios > QUANT_FUNCIONARIO_ALICOTA_REDUZIDA ? 
                ALICOTA_REDUZIDA : 
                ALICOTA_PADRAO;

            return RendaAnual * alicota;
        }

    }
}
