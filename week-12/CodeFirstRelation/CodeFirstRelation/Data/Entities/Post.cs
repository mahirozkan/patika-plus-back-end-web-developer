using System.ComponentModel.DataAnnotations;

namespace CodeFirstRelation.Data.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
