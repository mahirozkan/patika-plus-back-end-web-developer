using System.ComponentModel.DataAnnotations;

namespace CodeFirstBasic.Data.Entities
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Platform { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public decimal Rating { get; set; }
    }
}
