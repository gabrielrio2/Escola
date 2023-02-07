using System;
using System.Numerics;

namespace EscolaProjeto.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public  string  Matricula { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        public DateTime DataDeNascimento { get; set; }
    }
}
