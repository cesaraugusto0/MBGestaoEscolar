using System.Collections.Specialized;
using System.Globalization;

namespace MBGestaoEscolar.Entities
{
    public class Instrutor:Pessoa
    {
        public int InstrutorId { get; set; }
        public string FormacaoAcademica {  get; set; }
        public string Especialidade { get; set; }
        public Decimal ValorHoraAula { get; set; }
        public string StatusInstrutor { get; set; }

    }
}
