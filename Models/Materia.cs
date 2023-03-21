using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EscolaProjeto.Models
{
    public class Materia
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatorio")]
        public string Professor { get; set; }

        
    }
}

