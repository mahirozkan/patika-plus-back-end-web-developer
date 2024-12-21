using System.ComponentModel.DataAnnotations;

namespace CodeFirstBasic.Data.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public int ReleaseYear { get; set; }
    }
}
