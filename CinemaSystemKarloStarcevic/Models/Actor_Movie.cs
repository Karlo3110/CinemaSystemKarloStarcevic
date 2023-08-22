namespace CinemaSystemKarloStarcevic.Models
{
    public class Actor_Movie
    {
        //odnosi entiteta za bazu : Actor i Movie
        //fk
        public int MovieId { get; set; }
        //veza
        public Movie Movie { get; set; }
        //fk
        public int ActorId { get; set; }
        //veza
        public Actor Actor { get; set; }    
    }
}
