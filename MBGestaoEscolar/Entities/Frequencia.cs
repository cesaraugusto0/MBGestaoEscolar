namespace MBGestaoEscolar.Entities
{
    public class Frequencia
    {
        public int FrequenciaId { get; set; }
        public int InscricaoId { get; set; }
        public int MatereriaId { get; set; }
        public DateTime DataAula { get; set; }
        public Boolean Presente { get; set; }
        public string Justificativa { get; set; }
    }
}
