using IdentityandDataProtection.Data;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace IdentityandDataProtection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("Geçersiz kullanıcı.");
            }

            if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                return BadRequest("Email ve şifre gereklidir.");
            }

            // Şifreyi hash'leyerek kaydediyoruz
            user.Password = HashPassword(user.Password);

            _context.Users.Add(user);
            _context.SaveChanges(); 

            return Ok(new { Message = "Kayıt başarılı!" });
        }

        private string HashPassword(string password)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);  // Rasgele bir salt oluşturuyoruz
            }

            // Şifreyi hash'liyoruz
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return hashed;  // Şifreyi geri döndürüyoruz
        }
    }
}