﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaSystemKarloStarcevic.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //odnosi entiteta za bazu
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
