using Microsoft.EntityFrameworkCore;

namespace EscolaProjeto.Models
{
    public class BancoDeDados : DbContext

    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Escola> escolas { get; set; }
        public DbSet<Materia> materias { get; set; }
        public DbSet<Turma> turmas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"server=(localdb)\mssqllocaldb;Database=Teste;Integrated Security=True");
        }
       

    }
}
