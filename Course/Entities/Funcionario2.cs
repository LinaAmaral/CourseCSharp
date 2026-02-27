using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;


namespace Course.Entities
{
    class Funcionario2
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionario2(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }



    }
}
