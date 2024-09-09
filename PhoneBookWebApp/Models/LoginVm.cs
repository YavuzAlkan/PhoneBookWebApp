using System.ComponentModel.DataAnnotations;

namespace PhoneBookWebApp.Models
{
    public class LoginVm
    {
        [Required(ErrorMessage = "Email adresi gereklidir.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
            ErrorMessage = "Geçerli bir email adresi giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string Password { get; set; }
    }
}
