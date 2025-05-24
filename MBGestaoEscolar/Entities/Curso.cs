using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolar.Entities
{
    [Table("Curso")]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CursoId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int CargaHoraria { get; set; }
        public string Modalidade { get; set; }
        public string Trilha { get; set; }
        public int PontosCAP { get; set; }
        public string StatusCurso { get; set; }

        public int CoordenadorId { get; set; }
        // Navegação para coordenador
        [ForeignKey(nameof(CoordenadorId))]
        public Coordenador Coordenador { get; set; }
        public ICollection<Turma> turmas { get; set; }
    }
}
