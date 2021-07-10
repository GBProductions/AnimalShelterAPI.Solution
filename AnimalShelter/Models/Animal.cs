using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId {get; set; }
        [Required]
        [StringLength(20)]
        public string Name {get; set; }
        [Required]
        public string Species {get; set; }
        [Required]
        [Range(1,200, ErrorMessage = "Age must be between 1 and 100.")]
        public int Age {get; set; }
        [Required]
        public string Sex {get; set; }
    }
}