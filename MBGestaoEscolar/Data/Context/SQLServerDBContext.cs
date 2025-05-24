using MBGestaoEscolar.Entities;
using Microsoft.EntityFrameworkCore;

namespace MBGestaoEscolar.Data.Context
{
    public class SQLServerDBContext : DbContext
    {
        public SQLServerDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Coordenador> Coordenadores { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Instrutor> Instrutor { get; set; }
        public DbSet<Turma> Turmas { get; set; }
    }
}
