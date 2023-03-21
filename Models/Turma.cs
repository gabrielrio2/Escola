using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EscolaProjeto.Models
{
    public class Turma
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatorio")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "O Campo é obrigatorio")]
        public int EscolaId { get; set; }

        public Escola Escola { get; set; }

        public IEnumerable<Escola> listaEscola { get; set; }

        public int MateriaId { get; set; }

        public Materia Materia { get; set;}

        public IEnumerable<Materia> listaMateria { get; set; }
       
    }
}