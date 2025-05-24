using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolar.Entities
{
    [Table("Materia")]
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MateriaId { get; set; }

        [Required]
        public int TurmaId { get; set; }

        [Required]
        public int InstrutorId { get; set; }

        [Required, StringLength(150)]
        public string Nome { get; set; }

        [Required]
        public int CargaHoraria { get; set; }

        public decimal? PesoNota { get; set; }

        // Navegações
        [ForeignKey(nameof(TurmaId))]
        public Turma Turma { get; set; }

        [ForeignKey(nameof(InstrutorId))]
        public Instrutor Instrutor { get; set; }
    }
}
