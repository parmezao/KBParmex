using System.ComponentModel.DataAnnotations;

namespace JDKB.UI.Models
{
    public class SignInVM
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "Senha inválida - min: {2} max: {1}", MinimumLength = 5)]
        public string Senha { get; set; }

        public bool Lembrar { get; set; }
    }
}
