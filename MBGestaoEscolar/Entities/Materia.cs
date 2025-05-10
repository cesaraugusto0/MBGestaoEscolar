namespace MBGestaoEscolar.Entities
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public Turma Turma { get; set; }
        public Instrutor Instrutor { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int PesoNota { get; set; }
    }
}
