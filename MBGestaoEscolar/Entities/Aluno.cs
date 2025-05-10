using System.Security.Cryptography.X509Certificates;

namespace MBGestaoEscolar.Entities
{
    public class Aluno:Pessoa
    {
        public Aluno()
        {
        }
        public Aluno(string matricula, DateTime? dataNascimento)
        {
            Matricula = matricula;
            DataNascimento = dataNascimento;
        }

        public int AlunoId { get; set; }
        public string Matricula { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string StatusAluno { get; set; }
        public DateTime? DateTime {  get; set; }
        public ICollection<Inscricao> Inscricoes { get; set; } = new List<Inscricao>();

    }
}
