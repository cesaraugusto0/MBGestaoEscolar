using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolar.Entities
{
    [Table("Turma")]
    public class Turma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TurmaId { get; set; }

        [Required]
        public int CursoId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Codigo { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataInicio { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DataFim { get; set; }

        [StringLength(150)]
        public string Local { get; set; }

        [Required]
        [StringLength(50)]
        public string Modalidade { get; set; }

        [Required]
        public int NumeroVagas { get; set; }

        [Required]
        [StringLength(30)]
        public string StatusTurma { get; set; }

        [ForeignKey(nameof(CursoId))]
        public Curso Curso { get; set; }

        public ICollection<Inscricao> Inscricoes { get; set; } = new List<Inscricao>();
    }
}
