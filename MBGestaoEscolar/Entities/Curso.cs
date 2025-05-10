namespace MBGestaoEscolar.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public int CoordenadorId { get; set; }
        public string Name { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int CargaHoraria { get; set; }
        public string Modalidade { get; set; }
        public string Trilha { get; set; }
        public int PontosCAP { get; set; }
        public string StatusCurso { get; set; }
        public Coordenador Coordenador { get; set; }
        public ICollection<Turma> turmas { get; set; }
    }
}
