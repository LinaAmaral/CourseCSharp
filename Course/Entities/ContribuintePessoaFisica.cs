
namespace Course.Entities
{
    class ContribuintePessoaFisica : Contribuinte
    {
        double MENOR_ALICOTA = 0.15;
        double MAIOR_ALICOTA = 0.25;
        double ABATIMENTO_SAUDE = 0.5;
        double GANHO_MAX = 20000;
        public double GastoComSaude { get; set; }
        public ContribuintePessoaFisica(string nome, double rendaAnual, double gastoComSaude) : base(nome, rendaAnual)
        {
            GastoComSaude = gastoComSaude;
        }

        public override double ImpostoAPagar()
        {
            double imposto = (RendaAnual < GANHO_MAX) ? 
                (RendaAnual * MENOR_ALICOTA) : 
                (RendaAnual * MAIOR_ALICOTA);

            if( GastoComSaude > 0)
            {
                imposto -= (GastoComSaude * ABATIMENTO_SAUDE);
            }
            return imposto;
        }
    }
}
