using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAPI.Web.Context;
using WebAPI.Web.Models.PokemonModel;

namespace WebAPI.Web.Models.Repositories
{
    public class PokemonRepository
    {
        private readonly ApplicationDbContext _context;
        public PokemonRepository(ApplicationDbContext context)
        {
                _context= context;  
        }
        //public ICollection<Pokemon> GetPokemonList()
        //{
        //    var list=_context.Pokemons.OrderBy(p=> p.Id).ToList();  
        //    return list;    
        //}
        //public Pokemon GetPokemon(int id) {
        // return _context.Pokemons.Where(p => p.Id == id).SingleOrDefault(); 
        //}
        //public Pokemon GetPokemonName(string name)
        //{
        //    return _context.Pokemons.Where(p => p.Name == name).SingleOrDefault();
        //}

        //public bool PokemonExists(int id) {
            
        // return _context.Pokemons.Any(p=>p.Id== id);            
        //}
        //public decimal GetPokemonRating(int id)
        //{
        //    var review=_context.Reviews.Where(x=>x.Id==id);
        //    if (review.Count() <= 0)
        //        return 0;

        //    return ((decimal)review.Sum(x=>x.Rating) / review.Count());
        //}


    }
}
