using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaSystemKarloStarcevic.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }

        //odnosi entiteta za bazu

        public List<Movie> Movies { get; set; }

    }
}
