using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;

namespace EscolaProjeto.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="O Campo é obrigatorio")]
        public  string  Matricula { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatorio")]
        public string Cpf { get; set; }
          
        public int TurmaId { get; set; }
        
        public Turma Turma { get; set; }

        public IEnumerable<Turma> listaTurma { get; set; }

        

        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }
        public Aluno carregarPorCodigo(int Id) {
            BancoDeDados c=new BancoDeDados();
            return c.Alunos.Where(p=>p.Id== Id).FirstOrDefault();
        }
        public List<Aluno> getAll()
        {
            BancoDeDados c = new BancoDeDados();
            return c.Alunos.ToList();

        }
    }
}
