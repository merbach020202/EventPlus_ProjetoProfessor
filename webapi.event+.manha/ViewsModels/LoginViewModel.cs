using System.ComponentModel.DataAnnotations;

namespace webapi.event_.manha.ViewsModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="O Email é obrigatório!")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="A Senha é obrigatória!")]
        public string? Senha { get; set; }
    }
}
