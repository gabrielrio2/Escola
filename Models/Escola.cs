
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EscolaProjeto.Models
{
    public class Escola
    {
        [Key]
        public int Id { get; set; }       
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public string Endereço { get; set; }



    }
}
