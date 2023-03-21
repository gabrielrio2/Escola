
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaProjeto.Models
{
    public class Escola
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatorio")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatorio")]
        public string Endereço { get; set; }





    }
}
