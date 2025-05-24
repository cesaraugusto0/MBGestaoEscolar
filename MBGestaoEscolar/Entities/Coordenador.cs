using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolar.Entities
{
    [Table("Coordenador")]
    public class Coordenador:Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CoordenadorId { get; set; }
    }
}
