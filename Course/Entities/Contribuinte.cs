
namespace Course.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double ImpostoAPagar();

        public override string ToString()
        {
            return $"{Nome}: ${ImpostoAPagar()}";
        }
    }
}
