using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolar.Entities
{
    [Table("aluno")]
    public class Aluno:Pessoa
    {
        public Aluno()
        {
        }
        
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public string? Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Endereco { get; set; }
        public string StatusAluno { get; set; } = "Ativo";
        public DateTime DataCadastro { get; set; }

    }
}
