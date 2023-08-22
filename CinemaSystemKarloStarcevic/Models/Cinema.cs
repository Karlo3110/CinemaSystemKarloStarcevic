using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaSystemKarloStarcevic.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //odnosi entiteta za bazu
        public List<Movie> Movies { get; set; }


    }
}
