using CinemaSystemKarloStarcevic.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaSystemKarloStarcevic.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        //metoda za dodavanje u db
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        //metoda za brisanje
        void Delete(int id);
    }
}
