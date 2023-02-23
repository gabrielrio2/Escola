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
        public  string  Matricula { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
          
        public int EscolaId { get; set; }
        
        public Escola Escola { get; set; }

        public List<Escola> listaEscola { get; set; }


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
