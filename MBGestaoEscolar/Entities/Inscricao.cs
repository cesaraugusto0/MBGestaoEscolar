namespace MBGestaoEscolar.Entities
{
    public class Inscricao
    {
        public int InscricaoId { get; set; }
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
        public DateTime DataInscricao { get; set; }
        public string Status { get; set; }
    }
}
