using System.ComponentModel.DataAnnotations;

namespace ChapterFST1.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail Requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha Requerido")]
        public string Senha { get; set; }
    }
}
