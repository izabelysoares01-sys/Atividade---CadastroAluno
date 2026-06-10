using System.ComponentModel.DataAnnotations;

namespace CadastroAluno.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O RA é obrigatório.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O RA deve conter 8 dígitos.")]
        [Display(Name = "RA")]
        public string RA { get; set; } = string.Empty;

        [Required(ErrorMessage = "Selecione um curso.")]
        [Display(Name = "Curso")]
        public string Curso { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
