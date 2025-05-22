using System.ComponentModel.DataAnnotations.Schema;

namespace MBGestaoEscolar.Entities
{
    [Table("Coordenador")]
    public class Coordenador:Pessoa
    {
        public int CoordenadorId { get; set; }
    }
}
