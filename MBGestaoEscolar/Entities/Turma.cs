namespace MBGestaoEscolar.Entities
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public Curso Curso { get; set; }
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string local {  get; set; }
        public string Modalidade { get; set; }
        public int NumeroVagas { get; set; }
        public string StatusTurma { get; set; }

        // Relacionamento para navegação
        public ICollection<Materia> Materias { get; set; } = new List<Materia>();
        public ICollection<Inscricao> Inscricao { get; set;} = new List<Inscricao>();
    }
}
