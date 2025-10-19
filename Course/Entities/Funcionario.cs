using System.Globalization;
using System;


namespace Course.Entities
{
    class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario (string csvFuncionario)
        {
            string[] vect = csvFuncionario.Split(',');
            Nome = vect[0];
            Salario = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Funcionario))
            {
                throw new ArgumentException("Argumento não é do tipo Funcionario");
            }
            Funcionario other = obj as Funcionario;
            return Nome.CompareTo(other.Nome);

        }
    }
}
