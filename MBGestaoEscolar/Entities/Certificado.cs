using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MBGestaoEscolar.Entities
{
    public class Certificado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CertificadoId { get; set; }
        public string InscricaoId { get; set; }
        public int NumeroCertificado { get; set; }
        public DateTime DataEmissao { get; set; }
        public string QRCodeUrl { get; set; }
        public string HashValidacao { get; set; }
    }
}
