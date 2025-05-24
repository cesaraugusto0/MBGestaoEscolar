using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace MBGestaoEscolar.Entities
{
    [Table("Instrutor")]
    public class Instrutor:Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstrutorId { get; set; }
        [StringLength(200)]
        public string FormacaoAcademica {  get; set; }
        public string Especialidade { get; set; }
        public Decimal ValorHoraAula { get; set; }
        public string StatusInstrutor { get; set; }

    }
}
