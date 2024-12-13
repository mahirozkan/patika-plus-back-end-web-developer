using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models
{
    public class CrazyMusician
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Job is required.")]
        public string Job { get; set; }
        [Required(ErrorMessage = "Feature is required.")]
        public string Feature { get; set; }
    }
}
