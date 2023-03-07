using System.Collections.Generic;

namespace EscolaProjeto.Models
{
    public class Turma
    {
        public int Id { get; set; }

        public string Numero { get; set; }

        public int EscolaId { get; set; }

        public Escola Escola { get; set; }

        public List<Escola> listaEscola { get; set; }
    }
}