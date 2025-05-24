using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MBGestaoEscolar.ViewModels
{
    public class InstrutorViewModel
    {
        public int InstrutorId { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; } = "";

        [Required(ErrorMessage = "O CPF é obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Formato de CPF inválido")]
        [Display(Name = "CPF")]
        public string CPF { get; set; } = "";

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        [StringLength(100, ErrorMessage = "O email deve ter no máximo 100 caracteres")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; } = "";

        [StringLength(200, ErrorMessage = "A formação acadêmica deve ter no máximo 200 caracteres")]
        [Display(Name = "Formação Acadêmica")]
        public string FormacaoAcademica { get; set; } = "";

        [StringLength(150, ErrorMessage = "A especialidade deve ter no máximo 200 caracteres")]
        [Display(Name = "Especialidade")]
        public string Especialidade { get; set; } = "";

        [Required(ErrorMessage = "O valor hora aula é obrigatório")]
        [Display(Name = "Valor hora aula")]
        public Decimal ValorHoraAula { get; set; } = new();

        [Required(ErrorMessage = "O status é obrigatório")]
        [Display(Name = "Status do Instrutor")]
        public string StatusInstrutor { get; set; } = "";

        // Propriedades específicas da UI (adicione essas)
        public bool IsEdicao => InstrutorId > 0;
        public string TituloFormulario => IsEdicao ? "Editar Instrutor" : "Novo Instrutor";
        public string TextoBotao => IsEdicao ? "Atualizar" : "Salvar";
    }
}
