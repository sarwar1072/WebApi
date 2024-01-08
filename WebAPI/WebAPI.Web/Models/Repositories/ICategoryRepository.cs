using WebAPI.Web.Models.PokemonModel;

namespace WebAPI.Web.Models.Repositories
{
    public interface ICategoryRepository
    {
        Category GetCategoryById(int id);
        ICollection<Pokemon> GetPokemonByCategoryId(int categoryId);
    }
}
