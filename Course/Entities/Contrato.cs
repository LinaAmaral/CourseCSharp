
namespace Course.Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateOnly Data { get; set; }
        public double Valor { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Contrato (int numero, DateOnly data, double valor)
        {
            Numero = numero;
            Data = data;
            Valor = valor;
            Parcelas = new List<Parcela>();
        }

        public void AdicionarParcelas(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
