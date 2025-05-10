namespace MBGestaoEscolar.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public string ObterInformacoesContato()
        {
            return $"Nome: {Nome} - Email: {Email} - Telefone: {Telefone}";
        }
    }
}
