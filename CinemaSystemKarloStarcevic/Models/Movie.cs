using CinemaSystemKarloStarcevic.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSystemKarloStarcevic.Models
{
    public class Movie
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //odnosi entiteta za bazu

        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinema ref
        public int CinemaId { get; set; }
        //fk
        [ForeignKey("CinemaId")]

        //one to many veza
        public Cinema Cinema { get; set; }



        //producer veza
        public int ProducerId { get; set; }
        //fk
        [ForeignKey("ProducerId")]

        //one to many veza
        public Producer Producer { get; set; }
    }
}
