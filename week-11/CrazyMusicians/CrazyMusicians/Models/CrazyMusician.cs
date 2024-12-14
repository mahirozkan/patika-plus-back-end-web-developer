using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models
{
    public class CrazyMusician
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(30)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Job is required.")]
        [StringLength(30)]
        public string Job { get; set; }
        [Required(ErrorMessage = "Feature is required.")]
        [StringLength(50)]
        public string Feature { get; set; }
    }
}
