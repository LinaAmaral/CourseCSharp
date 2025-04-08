using Course.Entities.Exception;

namespace Course.Entities
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public Conta(int numero, double saldo, double limite)
        {
            Numero = numero;
            Saldo = saldo;
            Limite = limite;
        }

        public void Sacar(double valor)
        {
            if(valor>Limite || valor > Saldo)
            {
                throw new DomainException("Valor fora do limite aceitável");
            }

            Saldo -= valor;
        }
    }
}
