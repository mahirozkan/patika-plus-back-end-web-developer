using System.ComponentModel.DataAnnotations;

namespace IdentityandDataProtection.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur!")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }
    }
}
