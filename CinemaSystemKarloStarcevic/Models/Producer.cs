using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaSystemKarloStarcevic.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //odnosi entiteta za bazu

        public List<Movie> Movies { get; set; }

    }
}
