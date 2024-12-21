using System.ComponentModel.DataAnnotations;

namespace CodeFirstRelation.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        public List<Post> Posts { get; set; }
    }
}
