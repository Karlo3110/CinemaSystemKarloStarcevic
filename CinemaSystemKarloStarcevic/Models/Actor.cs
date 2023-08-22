using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaSystemKarloStarcevic.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //odnosi entiteta za bazu
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
