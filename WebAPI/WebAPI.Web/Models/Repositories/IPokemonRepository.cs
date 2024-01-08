using WebAPI.Web.Models.PokemonModel;

namespace WebAPI.Web.Models.Repositories
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemonList();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemonName(string name);
        bool PokemonExists(int id);
        decimal GetPokemonRating(int id);
    }
}