using System.ComponentModel.DataAnnotations;

namespace PhoneBookWebApp.Models
{
    public class ContactVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim gereklidir.")]
        [RegularExpression(@"^[a-zA-ZçÇğĞıİöÖşŞüÜ\s]{2,50}$", ErrorMessage = "İsim sadece harflerden oluşmalı ve 2 ile 50 karakter arasında olmalıdır.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim gereklidir.")]
        [RegularExpression(@"^[a-zA-ZçÇğĞıİöÖşŞüÜ\s]{2,50}$", ErrorMessage = "Soyisim sadece harflerden oluşmalı ve 2 ile 50 karakter arasında olmalıdır.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Telefon numarası gereklidir.")]
        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz.")]
        [RegularExpression(@"^\+90\d{10}$", ErrorMessage = "Lütfen geçerli bir telefon numarası giriniz. Örnek: +905321234567")]
        public string PhoneNumber { get; set; }
    }
}
